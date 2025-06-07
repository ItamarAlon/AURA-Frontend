using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AURA_Frontend
{
    public partial class Chatbox : UserControl
    {
        public event EventHandler<EventArgs<string>> MessageSent;
        public ChatboxInfo chatbox_info;
        public OpenFileDialog fileDialog = new OpenFileDialog();
        public string initialdirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        private const bool v_IsReceiver = true;

        public Chatbox()
        {
            InitializeComponent();

            chatbox_info = new ChatboxInfo()
            {
                Sender = "User",
                Receiver = "LLM",
                StatusPlaceholder = "On"
            };

            //clientnameLabel.Text = chatbox_info.NamePlaceholder;
            chatTextbox.Text = chatbox_info.ChatPlaceholder;

            chatTextbox.Enter += chatTextBox_Enter;
            chatTextbox.Leave += chatTextBox_Leave;
            sendButton.Click += sendButton_Click;
            attachButton.Click += attachButton_Click;
            removeButton.Click += removeButton_Click;
            chatTextbox.KeyDown += chatTextbox_KeyDown;

            ReceiveMessage("Hi. How can I help you?");
            //SendMessage("Hello There");
        }
        public Chatbox(ChatboxInfo _chatbox_info)
        {
            InitializeComponent();

            chatbox_info = _chatbox_info;

            clientnameLabel.Text = chatbox_info.NamePlaceholder;
            chatTextbox.Text = chatbox_info.ChatPlaceholder;

            chatTextbox.Enter += chatTextBox_Enter;
            chatTextbox.Leave += chatTextBox_Leave;
            sendButton.Click += sendButton_Click;
            attachButton.Click += attachButton_Click;
            removeButton.Click += removeButton_Click;

            chatTextbox.KeyDown += chatTextbox_KeyDown;

            AddMessage(null);
        }

        /// <summary>
        /// ChatItem objects are generated dynamically from IChatModel. By default, a ChatItem is allowed to be resized up to 60% of the entire screen.
        /// I've thought about it being editable from outside, but there's no real need to.
        /// </summary>
        /// <param name="message"></param>
        public void AddMessage(IChatModel message)
        {
            var chatItem = new ChatItem(message);
            chatItem.Name = "chatItem" + itemsPanel.Controls.Count;
            chatItem.Dock = DockStyle.Top;
            itemsPanel.Controls.Add(chatItem);
            chatItem.BringToFront();

            chatItem.ResizeBubbles((int)(itemsPanel.Width * 0.6));

            itemsPanel.ScrollControlIntoView(chatItem);
        }

        //Improves the chat UI slightly by having a placeholder text. Note that this is implemented because Winforms doesn't have a native "placeholder" UI. Can be buggy.
        void chatTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(chatTextbox.Text))
            {
                chatTextbox.Text = chatbox_info.ChatPlaceholder;
                chatTextbox.ForeColor = Color.Gray;
            }
        }

        //Improves the chat UI slightly by having a placeholder text. Note that this is implemented because Winforms doesn't have a native "placeholder" UI. Can be buggy.
        void chatTextBox_Enter(object sender, EventArgs e)
        {
            chatTextbox.ForeColor = Color.Black;
            if (chatTextbox.Text == chatbox_info.ChatPlaceholder)
            {
                chatTextbox.Text = "";
            }
        }

        //Cross-tested this with the Twilio API and the RingCentral API, and async messaging is the way to go.
        async void sendButton_Click(object sender, EventArgs e)
        {
            sendUserTypedMessage();
        }

        private void sendUserTypedMessage()
        {
            string chatMessage = chatTextbox.Text;
            SendMessage(chatMessage);
            OnMessageSent(chatMessage);
        }

        public async void SendMessage(string message)
        {
            parseMessage(message, !v_IsReceiver);
        }

        public async void ReceiveMessage(string message)
        {
            parseMessage(message, v_IsReceiver);
        }

        private void parseMessage(string message, bool isReceiver = !v_IsReceiver)
        {
            IChatModel chatModel = null;
            TextChatModel textModel = null;
            string author = isReceiver ? chatbox_info.Receiver : chatbox_info.Sender;

            //Each IChatModel is specifically built for a single purpose. For that reason, if you want to display a text item AND and image, you'd make two IChatModels for
            //their respective purposes. AttachmentChatModel and ImageChatModel, however, can really be used interchangeably.
            if (chatbox_info.Attachment != null && chatbox_info.AttachmentType.Contains("image"))
            {
                chatModel = new ImageChatModel()
                {
                    Author = author,
                    Image = Image.FromStream(new MemoryStream(chatbox_info.Attachment)),
                    ImageName = chatbox_info.AttachmentName,
                    Inbound = isReceiver,
                    Read = true,
                    Time = DateTime.Now,
                };

            }
            else if (chatbox_info.Attachment != null)
            {
                chatModel = new AttachmentChatModel()
                {
                    Author = author,
                    Attachment = chatbox_info.Attachment,
                    Filename = chatbox_info.AttachmentName,
                    Read = true,
                    Inbound = isReceiver,
                    Time = DateTime.Now
                };
            }

            if (!string.IsNullOrWhiteSpace(message) && message != chatbox_info.ChatPlaceholder)
            {
                textModel = new TextChatModel()
                {
                    Author = author,
                    Body = message,
                    Inbound = isReceiver,
                    Read = true,
                    Time = DateTime.Now
                };
            }

            try
            {
                /*

                    INSERT SENDING LOGIC HERE. Again, this is just a UserControl, not a complete app. For the Ringcentral API, I was able to reduce this section
                    down to a single method.

                */

                if (chatModel != null)
                {
                    AddMessage(chatModel);
                    cancelAttachment();
                }
                if (textModel != null)
                {
                    AddMessage(textModel);
                    chatTextbox.Text = string.Empty;
                }
            }
            catch (Exception exc)
            {
                //If any exception is found, then it is printed on the screen. Feel free to change this method if you don't want people to see exceptions.
                textModel = new TextChatModel()
                {
                    Author = author,
                    Body = "The message could not be processed. Please see the reason below.\r\n" + exc.Message,
                    Inbound = isReceiver,
                    Read = true,
                    Time = DateTime.Now
                };
                AddMessage(textModel);
            }
        }

        protected virtual void OnMessageSent(EventArgs<string> e)
        {
            MessageSent?.Invoke(this, e);
        }

        void attachButton_Click(object sender, EventArgs e)
        {
            buildAttachment();
        }

        private void buildAttachment()
        {
            fileDialog.InitialDirectory = initialdirectory;
            fileDialog.Reset();
            fileDialog.Multiselect = false;

            var result = fileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string selected = fileDialog.FileName;
                try
                {
                    var file = File.ReadAllBytes(selected);
                    //Limits the size of the attachment to 1.45 MB, which is less than the max possible size of an SMS attachment of 1.5 MB.
                    if (file.Length > 1450000)
                    {
                        MessageBox.Show("The attachment provided " + fileDialog.SafeFileName + " is too big to be sent by SMS. Please select another.", "Attachment not added.");
                        return;
                    }
                    else
                    {
                        chatbox_info.Attachment = file;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("There was an issue with retrieving the file.", "File Operation Error");
                }
            }
            else
            {
                return;
            }

            if (chatbox_info.Attachment != null)
            {
                string smallname = fileDialog.SafeFileName;
                chatbox_info.AttachmentName = fileDialog.SafeFileName;

                string name = Path.GetFileNameWithoutExtension(smallname);
                string extension = Path.GetExtension(smallname);
                if (smallname.Length > 12)
                {
                    smallname = name.Substring(0, 7) + ".." + extension;
                    //attachButton.Text = smallname;
                }
                else
                {
                    //attachButton.Text = smallname;
                }

                removeButton.Visible = true;
                //attachButton.Width = 115;
                chatbox_info.AttachmentType = ChatUtility.GetMimeType(extension);
            }
        }

        void removeButton_Click(object sender, EventArgs e)
        {
            cancelAttachment();
        }

        private void cancelAttachment()
        {
            attachButton.Text = string.Empty;
            chatbox_info.Attachment = null;
            chatbox_info.AttachmentName = null;
            chatbox_info.AttachmentType = null;
            removeButton.Visible = false;
            attachButton.Width = 35;
        }

        //Inspired from Slack, you can also press Shift + Enter to enter text.
        private void chatTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            sendMessageOnShiftEnter(e.Shift, e.KeyCode);
        }

        private async void sendMessageOnShiftEnter(bool wasShiftPressed, Keys pressedKey)
        {
            if (wasShiftPressed && pressedKey == Keys.Enter)
            {
                sendUserTypedMessage();
            }
        }

        //When the Control resizes, it will trigger the resize event for all the ChatItem object inside as well, again with a default width of 60%.
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            foreach (var control in itemsPanel.Controls)
            {
                if (control is ChatItem)
                {
                    (control as ChatItem).ResizeBubbles((int)(itemsPanel.Width * 0.6));
                }
            }
        }

        private void topPanel_Paint(object sender, PaintEventArgs e)
        {
            //drawBorderAroundPanel(e, topPanel, Color.FromArgb(78, 81, 87));
        }

        private void bottomPanel_Paint(object sender, PaintEventArgs e)
        {
            //drawBorderAroundPanel(e, bottomPanel, Color.FromArgb(78, 81, 87));
        }

        private void itemsPanel_Paint(object sender, PaintEventArgs e)
        {
            //drawBorderAroundPanel(e, itemsPanel, Color.FromArgb(225, 227, 227));
        }

        private void drawBorderAroundPanel(PaintEventArgs e, Panel panel, Color color)
        {
            ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle,
                color, 1, ButtonBorderStyle.Solid,  // left
                color, 1, ButtonBorderStyle.Solid,  // top
                color, 1, ButtonBorderStyle.Solid,  // right
                color, 1, ButtonBorderStyle.Solid); // bottom
        }

        private void attachButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}

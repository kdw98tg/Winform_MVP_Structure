namespace MVP_Structure
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonSave = new Button();
            listViewUser = new ListView();
            userId = new ColumnHeader();
            userName = new ColumnHeader();
            userAge = new ColumnHeader();
            labelUserName = new Label();
            textBoxUserName = new TextBox();
            label2 = new Label();
            textBoxUserAge = new TextBox();
            buttonBluetoothOption = new Button();
            labelBluetoothDeviceName = new Label();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(683, 404);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "저장";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // listViewUser
            // 
            listViewUser.Columns.AddRange(new ColumnHeader[] { userId, userName, userAge });
            listViewUser.GridLines = true;
            listViewUser.Location = new Point(22, 53);
            listViewUser.Name = "listViewUser";
            listViewUser.Size = new Size(544, 320);
            listViewUser.TabIndex = 1;
            listViewUser.UseCompatibleStateImageBehavior = false;
            listViewUser.View = System.Windows.Forms.View.Details;
            // 
            // userId
            // 
            userId.Text = "유저 id";
            // 
            // userName
            // 
            userName.Text = "유저 이름";
            userName.Width = 200;
            // 
            // userAge
            // 
            userAge.Text = "유저 나이";
            userAge.Width = 100;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Location = new Point(610, 78);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(31, 15);
            labelUserName.TabIndex = 2;
            labelUserName.Text = "이름";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(683, 75);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(100, 23);
            textBoxUserName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Location = new Point(610, 122);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "나이";
            // 
            // textBoxUserAge
            // 
            textBoxUserAge.Location = new Point(683, 119);
            textBoxUserAge.Name = "textBoxUserAge";
            textBoxUserAge.Size = new Size(100, 23);
            textBoxUserAge.TabIndex = 3;
            // 
            // buttonBluetoothOption
            // 
            buttonBluetoothOption.Location = new Point(13, 404);
            buttonBluetoothOption.Name = "buttonBluetoothOption";
            buttonBluetoothOption.Size = new Size(122, 23);
            buttonBluetoothOption.TabIndex = 4;
            buttonBluetoothOption.Text = "블루투스 설정창";
            buttonBluetoothOption.UseVisualStyleBackColor = true;
            buttonBluetoothOption.Click += buttonBluetoothOption_Click;
            // 
            // labelBluetoothDeviceName
            // 
            labelBluetoothDeviceName.AutoSize = true;
            labelBluetoothDeviceName.Location = new Point(150, 408);
            labelBluetoothDeviceName.Name = "labelBluetoothDeviceName";
            labelBluetoothDeviceName.Size = new Size(39, 15);
            labelBluetoothDeviceName.TabIndex = 5;
            labelBluetoothDeviceName.Text = "label1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelBluetoothDeviceName);
            Controls.Add(buttonBluetoothOption);
            Controls.Add(textBoxUserAge);
            Controls.Add(label2);
            Controls.Add(textBoxUserName);
            Controls.Add(labelUserName);
            Controls.Add(listViewUser);
            Controls.Add(buttonSave);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private ListView listViewUser;
        private ColumnHeader userId;
        private ColumnHeader userName;
        private ColumnHeader userAge;
        private Label labelUserName;
        private TextBox textBoxUserName;
        private Label label2;
        private TextBox textBoxUserAge;
        private Button buttonBluetoothOption;
        private Label labelBluetoothDeviceName;
    }
}

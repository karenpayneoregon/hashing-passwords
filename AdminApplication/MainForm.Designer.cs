using AdminApplication.Classes;

namespace AdminApplication;

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
        BindingNavigator1 = new CoreBindingNavigator();
        label1 = new Label();
        UserNameTextBox = new TextBox();
        label2 = new Label();
        PasswordTextBox = new TextBox();
        BindingNavigator1.BeginInit();
        SuspendLayout();
        // 
        // BindingNavigator1
        // 
        BindingNavigator1.ImageScalingSize = new Size(20, 20);
        BindingNavigator1.Location = new Point(0, 0);
        BindingNavigator1.Name = "BindingNavigator1";
        BindingNavigator1.Size = new Size(687, 27);
        BindingNavigator1.TabIndex = 0;
        BindingNavigator1.Text = "coreBindingNavigator1";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(28, 57);
        label1.Name = "label1";
        label1.Size = new Size(79, 20);
        label1.TabIndex = 1;
        label1.Text = "User name";
        // 
        // UserNameTextBox
        // 
        UserNameTextBox.Location = new Point(28, 80);
        UserNameTextBox.Name = "UserNameTextBox";
        UserNameTextBox.Size = new Size(230, 27);
        UserNameTextBox.TabIndex = 2;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(28, 120);
        label2.Name = "label2";
        label2.Size = new Size(70, 20);
        label2.TabIndex = 3;
        label2.Text = "Password";
        // 
        // PasswordTextBox
        // 
        PasswordTextBox.Location = new Point(28, 143);
        PasswordTextBox.Name = "PasswordTextBox";
        PasswordTextBox.Size = new Size(647, 27);
        PasswordTextBox.TabIndex = 4;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(687, 192);
        Controls.Add(PasswordTextBox);
        Controls.Add(label2);
        Controls.Add(UserNameTextBox);
        Controls.Add(label1);
        Controls.Add(BindingNavigator1);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Admin";
        BindingNavigator1.EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private CoreBindingNavigator BindingNavigator1;
    private Label label1;
    private TextBox UserNameTextBox;
    private Label label2;
    private TextBox PasswordTextBox;
}

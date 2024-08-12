<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Web_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        BtnLogin = New Button()
        txtId_pengguna = New TextBox()
        txtKata_laluan = New TextBox()
        lblLog_masuk = New Label()
        lblKata_laluan = New Label()
        lblId_pengguna = New Label()
        SuspendLayout()
        ' 
        ' BtnLogin
        ' 
        BtnLogin.Location = New Point(105, 141)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(75, 23)
        BtnLogin.TabIndex = 0
        BtnLogin.Text = "Login"
        BtnLogin.UseVisualStyleBackColor = True
        ' 
        ' txtId_pengguna
        ' 
        txtId_pengguna.Location = New Point(118, 58)
        txtId_pengguna.Name = "txtId_pengguna"
        txtId_pengguna.Size = New Size(147, 23)
        txtId_pengguna.TabIndex = 1
        ' 
        ' txtKata_laluan
        ' 
        txtKata_laluan.Location = New Point(118, 96)
        txtKata_laluan.Name = "txtKata_laluan"
        txtKata_laluan.Size = New Size(147, 23)
        txtKata_laluan.TabIndex = 2
        ' 
        ' lblLog_masuk
        ' 
        lblLog_masuk.AutoSize = True
        lblLog_masuk.Location = New Point(106, 28)
        lblLog_masuk.Name = "lblLog_masuk"
        lblLog_masuk.Size = New Size(73, 15)
        lblLog_masuk.TabIndex = 5
        lblLog_masuk.Text = "LOG MASUK"
        ' 
        ' lblKata_laluan
        ' 
        lblKata_laluan.AutoSize = True
        lblKata_laluan.Location = New Point(12, 96)
        lblKata_laluan.Name = "lblKata_laluan"
        lblKata_laluan.Size = New Size(68, 15)
        lblKata_laluan.TabIndex = 6
        lblKata_laluan.Text = "Kata Lalaun"
        ' 
        ' lblId_pengguna
        ' 
        lblId_pengguna.AutoSize = True
        lblId_pengguna.Location = New Point(12, 58)
        lblId_pengguna.Name = "lblId_pengguna"
        lblId_pengguna.Size = New Size(75, 15)
        lblId_pengguna.TabIndex = 7
        lblId_pengguna.Text = "ID Pengguna"
        ' 
        ' Web_form
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(278, 172)
        Controls.Add(lblId_pengguna)
        Controls.Add(lblKata_laluan)
        Controls.Add(lblLog_masuk)
        Controls.Add(txtKata_laluan)
        Controls.Add(txtId_pengguna)
        Controls.Add(BtnLogin)
        Name = "Web_form"
        Text = "web form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnLogin As Button
    Friend WithEvents txtId_pengguna As TextBox
    Friend WithEvents txtKata_laluan As TextBox
    Friend WithEvents lblLog_masuk As Label
    Friend WithEvents lblKata_laluan As Label
    Friend WithEvents lblId_pengguna As Label

End Class

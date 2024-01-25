<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(LoginForm1))
        UsernameLabel = New Label()
        PasswordLabel = New Label()
        txt_username = New TextBox()
        txt_password = New TextBox()
        OK = New Button()
        Cancel = New Button()
        btn_registo = New Button()
        SuspendLayout()
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.Location = New Point(86, 144)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(220, 23)
        UsernameLabel.TabIndex = 0
        UsernameLabel.Text = "Usuário"
        UsernameLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.Location = New Point(86, 201)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(220, 23)
        PasswordLabel.TabIndex = 2
        PasswordLabel.Text = "&Senha"
        PasswordLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txt_username
        ' 
        txt_username.Location = New Point(88, 164)
        txt_username.Name = "txt_username"
        txt_username.Size = New Size(220, 27)
        txt_username.TabIndex = 1
        ' 
        ' txt_password
        ' 
        txt_password.Location = New Point(88, 221)
        txt_password.Name = "txt_password"
        txt_password.PasswordChar = "*"c
        txt_password.Size = New Size(220, 27)
        txt_password.TabIndex = 3
        ' 
        ' OK
        ' 
        OK.Location = New Point(76, 281)
        OK.Name = "OK"
        OK.Size = New Size(94, 29)
        OK.TabIndex = 4
        OK.Text = "&OK"
        ' 
        ' Cancel
        ' 
        Cancel.DialogResult = DialogResult.Cancel
        Cancel.Location = New Point(200, 281)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(94, 29)
        Cancel.TabIndex = 5
        Cancel.Text = "&Cancelar"
        ' 
        ' btn_registo
        ' 
        btn_registo.Location = New Point(127, 341)
        btn_registo.Name = "btn_registo"
        btn_registo.Size = New Size(117, 37)
        btn_registo.TabIndex = 6
        btn_registo.Text = "Novo Usuário"
        btn_registo.UseVisualStyleBackColor = True
        ' 
        ' LoginForm1
        ' 
        AcceptButton = OK
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        CancelButton = Cancel
        ClientSize = New Size(381, 463)
        Controls.Add(btn_registo)
        Controls.Add(Cancel)
        Controls.Add(OK)
        Controls.Add(txt_password)
        Controls.Add(txt_username)
        Controls.Add(PasswordLabel)
        Controls.Add(UsernameLabel)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.FixedDialog
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "LoginForm1"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterParent
        Text = "LoginForm1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_registo As Button
End Class

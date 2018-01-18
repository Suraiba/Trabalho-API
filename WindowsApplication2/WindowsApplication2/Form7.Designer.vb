<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.nome = New System.Windows.Forms.Label()
        Me.tipo = New System.Windows.Forms.Label()
        Me.pgrupo = New System.Windows.Forms.Label()
        Me.mato = New System.Windows.Forms.Label()
        Me.rato = New System.Windows.Forms.Label()
        Me.config = New System.Windows.Forms.Label()
        Me.ebfus = New System.Windows.Forms.Label()
        Me.descricao = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nome
        '
        Me.nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nome.Location = New System.Drawing.Point(635, 9)
        Me.nome.Name = "nome"
        Me.nome.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nome.Size = New System.Drawing.Size(100, 40)
        Me.nome.TabIndex = 0
        '
        'tipo
        '
        Me.tipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tipo.Location = New System.Drawing.Point(635, 49)
        Me.tipo.Name = "tipo"
        Me.tipo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tipo.Size = New System.Drawing.Size(100, 40)
        Me.tipo.TabIndex = 1
        '
        'pgrupo
        '
        Me.pgrupo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pgrupo.Location = New System.Drawing.Point(635, 89)
        Me.pgrupo.Name = "pgrupo"
        Me.pgrupo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.pgrupo.Size = New System.Drawing.Size(100, 40)
        Me.pgrupo.TabIndex = 2
        '
        'mato
        '
        Me.mato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mato.Location = New System.Drawing.Point(635, 129)
        Me.mato.Name = "mato"
        Me.mato.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.mato.Size = New System.Drawing.Size(100, 40)
        Me.mato.TabIndex = 3
        '
        'rato
        '
        Me.rato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rato.Location = New System.Drawing.Point(635, 169)
        Me.rato.Name = "rato"
        Me.rato.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rato.Size = New System.Drawing.Size(100, 40)
        Me.rato.TabIndex = 4
        Me.rato.Text = "Label5"
        '
        'config
        '
        Me.config.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.config.Location = New System.Drawing.Point(635, 209)
        Me.config.Name = "config"
        Me.config.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.config.Size = New System.Drawing.Size(100, 40)
        Me.config.TabIndex = 5
        Me.config.Text = "Label6"
        '
        'ebfus
        '
        Me.ebfus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ebfus.Location = New System.Drawing.Point(635, 249)
        Me.ebfus.Name = "ebfus"
        Me.ebfus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ebfus.Size = New System.Drawing.Size(100, 40)
        Me.ebfus.TabIndex = 6
        Me.ebfus.Text = "Label7"
        '
        'descricao
        '
        Me.descricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.descricao.Location = New System.Drawing.Point(223, 305)
        Me.descricao.Name = "descricao"
        Me.descricao.Size = New System.Drawing.Size(406, 44)
        Me.descricao.TabIndex = 7
        Me.descricao.Text = "Label1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(388, 302)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 368)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.descricao)
        Me.Controls.Add(Me.ebfus)
        Me.Controls.Add(Me.config)
        Me.Controls.Add(Me.rato)
        Me.Controls.Add(Me.mato)
        Me.Controls.Add(Me.pgrupo)
        Me.Controls.Add(Me.tipo)
        Me.Controls.Add(Me.nome)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents nome As System.Windows.Forms.Label
    Friend WithEvents tipo As System.Windows.Forms.Label
    Friend WithEvents pgrupo As System.Windows.Forms.Label
    Friend WithEvents mato As System.Windows.Forms.Label
    Friend WithEvents rato As System.Windows.Forms.Label
    Friend WithEvents config As System.Windows.Forms.Label
    Friend WithEvents ebfus As System.Windows.Forms.Label
    Friend WithEvents descricao As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class

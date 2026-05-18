<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        btnMasuk = New Button()
        btnKeluar = New Button()
        SuspendLayout()
        ' 
        ' btnMasuk
        ' 
        btnMasuk.BackColor = Color.Yellow
        btnMasuk.FlatAppearance.BorderColor = Color.Gray
        btnMasuk.FlatStyle = FlatStyle.Flat
        btnMasuk.Font = New Font("Novecento sans wide Normal", 9F, FontStyle.Bold)
        btnMasuk.Location = New Point(268, 252)
        btnMasuk.Name = "btnMasuk"
        btnMasuk.Size = New Size(75, 23)
        btnMasuk.TabIndex = 5
        btnMasuk.Text = "Masuk"
        btnMasuk.UseVisualStyleBackColor = False
        ' 
        ' btnKeluar
        ' 
        btnKeluar.BackColor = Color.Yellow
        btnKeluar.FlatAppearance.BorderColor = Color.Gray
        btnKeluar.FlatStyle = FlatStyle.Flat
        btnKeluar.Font = New Font("Novecento sans wide Normal", 9F, FontStyle.Bold)
        btnKeluar.Location = New Point(460, 252)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(75, 23)
        btnKeluar.TabIndex = 6
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.Home
        BackgroundImageLayout = ImageLayout.Zoom
        ClientSize = New Size(800, 423)
        Controls.Add(btnKeluar)
        Controls.Add(btnMasuk)
        DoubleBuffered = True
        Name = "Form1"
        Text = "Login-Form"
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnMasuk As Button
    Friend WithEvents btnKeluar As Button

End Class

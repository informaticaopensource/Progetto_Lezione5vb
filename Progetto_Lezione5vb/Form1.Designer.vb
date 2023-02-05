<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcognome = New System.Windows.Forms.TextBox()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.txtdatanascita = New System.Windows.Forms.TextBox()
        Me.txtluogonascita = New System.Windows.Forms.TextBox()
        Me.txtprovincia = New System.Windows.Forms.TextBox()
        Me.btnaggiungi = New System.Windows.Forms.Button()
        Me.btnvisualizza = New System.Windows.Forms.Button()
        Me.btnfine = New System.Windows.Forms.Button()
        Me.btncancella = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(215, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(218, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(221, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(218, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(221, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Label5"
        '
        'txtcognome
        '
        Me.txtcognome.Location = New System.Drawing.Point(371, 48)
        Me.txtcognome.Name = "txtcognome"
        Me.txtcognome.Size = New System.Drawing.Size(100, 22)
        Me.txtcognome.TabIndex = 5
        '
        'txtnome
        '
        Me.txtnome.Location = New System.Drawing.Point(371, 95)
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(100, 22)
        Me.txtnome.TabIndex = 6
        '
        'txtdatanascita
        '
        Me.txtdatanascita.Location = New System.Drawing.Point(371, 143)
        Me.txtdatanascita.Name = "txtdatanascita"
        Me.txtdatanascita.Size = New System.Drawing.Size(100, 22)
        Me.txtdatanascita.TabIndex = 7
        '
        'txtluogonascita
        '
        Me.txtluogonascita.Location = New System.Drawing.Point(371, 197)
        Me.txtluogonascita.Name = "txtluogonascita"
        Me.txtluogonascita.Size = New System.Drawing.Size(100, 22)
        Me.txtluogonascita.TabIndex = 8
        '
        'txtprovincia
        '
        Me.txtprovincia.Location = New System.Drawing.Point(371, 241)
        Me.txtprovincia.Name = "txtprovincia"
        Me.txtprovincia.Size = New System.Drawing.Size(100, 22)
        Me.txtprovincia.TabIndex = 9
        '
        'btnaggiungi
        '
        Me.btnaggiungi.Location = New System.Drawing.Point(160, 338)
        Me.btnaggiungi.Name = "btnaggiungi"
        Me.btnaggiungi.Size = New System.Drawing.Size(133, 41)
        Me.btnaggiungi.TabIndex = 10
        Me.btnaggiungi.Text = "Button1"
        Me.btnaggiungi.UseVisualStyleBackColor = True
        '
        'btnvisualizza
        '
        Me.btnvisualizza.Location = New System.Drawing.Point(299, 337)
        Me.btnvisualizza.Name = "btnvisualizza"
        Me.btnvisualizza.Size = New System.Drawing.Size(129, 42)
        Me.btnvisualizza.TabIndex = 11
        Me.btnvisualizza.Text = "Button2"
        Me.btnvisualizza.UseVisualStyleBackColor = True
        '
        'btnfine
        '
        Me.btnfine.Location = New System.Drawing.Point(472, 336)
        Me.btnfine.Name = "btnfine"
        Me.btnfine.Size = New System.Drawing.Size(109, 43)
        Me.btnfine.TabIndex = 12
        Me.btnfine.Text = "Button1"
        Me.btnfine.UseVisualStyleBackColor = True
        '
        'btncancella
        '
        Me.btncancella.Location = New System.Drawing.Point(630, 337)
        Me.btncancella.Name = "btncancella"
        Me.btncancella.Size = New System.Drawing.Size(75, 42)
        Me.btncancella.TabIndex = 13
        Me.btncancella.Text = "Button1"
        Me.btncancella.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btncancella)
        Me.Controls.Add(Me.btnfine)
        Me.Controls.Add(Me.btnvisualizza)
        Me.Controls.Add(Me.btnaggiungi)
        Me.Controls.Add(Me.txtprovincia)
        Me.Controls.Add(Me.txtluogonascita)
        Me.Controls.Add(Me.txtdatanascita)
        Me.Controls.Add(Me.txtnome)
        Me.Controls.Add(Me.txtcognome)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Gestione Anagrafica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtcognome As TextBox
    Friend WithEvents txtnome As TextBox
    Friend WithEvents txtdatanascita As TextBox
    Friend WithEvents txtluogonascita As TextBox
    Friend WithEvents txtprovincia As TextBox
    Friend WithEvents btnaggiungi As Button
    Friend WithEvents btnvisualizza As Button
    Friend WithEvents btnfine As Button
    Friend WithEvents btncancella As Button
End Class

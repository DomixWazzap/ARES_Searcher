<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ARES_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ARES_Form))
        ICO_TextBox = New TextBox()
        Hledej_Button = New Button()
        ZadejICO_Label = New Label()
        Vysledek_GroupBox = New GroupBox()
        Vysledek_TextBox = New TextBox()
        Vysledek_Label = New Label()
        Chyba_Label = New Label()
        Vysledek_GroupBox.SuspendLayout()
        SuspendLayout()
        ' 
        ' ICO_TextBox
        ' 
        ICO_TextBox.Location = New Point(130, 20)
        ICO_TextBox.Margin = New Padding(4, 5, 4, 5)
        ICO_TextBox.Name = "ICO_TextBox"
        ICO_TextBox.Size = New Size(141, 31)
        ICO_TextBox.TabIndex = 0
        AddHandler ICO_TextBox.KeyDown, AddressOf ICO_TextBox_KeyDown
        ' 
        ' Hledej_Button
        ' 
        Hledej_Button.Location = New Point(20, 80)
        Hledej_Button.Margin = New Padding(4, 5, 4, 5)
        Hledej_Button.Name = "Hledej_Button"
        Hledej_Button.Size = New Size(107, 38)
        Hledej_Button.TabIndex = 1
        Hledej_Button.Text = "Hledej"
        Hledej_Button.UseVisualStyleBackColor = True
        ' 
        ' ZadejICO_Label
        ' 
        ZadejICO_Label.AutoSize = True
        ZadejICO_Label.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        ZadejICO_Label.Location = New Point(20, 24)
        ZadejICO_Label.Name = "ZadejICO_Label"
        ZadejICO_Label.Size = New Size(95, 25)
        ZadejICO_Label.TabIndex = 2
        ZadejICO_Label.Text = "Zadej IČO"
        ' 
        ' Vysledek_GroupBox
        ' 
        Vysledek_GroupBox.Controls.Add(Vysledek_TextBox)
        Vysledek_GroupBox.Controls.Add(Vysledek_Label)
        Vysledek_GroupBox.Location = New Point(20, 150)
        Vysledek_GroupBox.Name = "Vysledek_GroupBox"
        Vysledek_GroupBox.Size = New Size(490, 210)
        Vysledek_GroupBox.TabIndex = 3
        Vysledek_GroupBox.TabStop = False
        Vysledek_GroupBox.Text = "Výsledek"
        ' 
        ' Vysledek_TextBox
        ' 
        Vysledek_TextBox.BorderStyle = BorderStyle.None
        Vysledek_TextBox.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        Vysledek_TextBox.Location = New Point(15, 35)
        Vysledek_TextBox.Multiline = True
        Vysledek_TextBox.Name = "Vysledek_TextBox"
        Vysledek_TextBox.ReadOnly = True
        Vysledek_TextBox.Size = New Size(460, 160)
        Vysledek_TextBox.TabIndex = 2
        ' 
        ' Vysledek_Label
        ' 
        Vysledek_Label.Location = New Point(0, 0)
        Vysledek_Label.Name = "Vysledek_Label"
        Vysledek_Label.Size = New Size(100, 23)
        Vysledek_Label.TabIndex = 0
        Vysledek_Label.Text = "Výsledek"
        ' 
        ' Chyba_Label
        ' 
        Chyba_Label.AutoSize = True
        Chyba_Label.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        Chyba_Label.ForeColor = Color.Red
        Chyba_Label.Location = New Point(280, 24)
        Chyba_Label.Name = "Chyba_Label"
        Chyba_Label.Size = New Size(131, 25)
        Chyba_Label.TabIndex = 4
        Chyba_Label.Text = "* Neplatné IČO"
        Chyba_Label.Visible = False
        ' 
        ' ARES_Form
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(537, 377)
        Controls.Add(Chyba_Label)
        Controls.Add(Vysledek_GroupBox)
        Controls.Add(ZadejICO_Label)
        Controls.Add(Hledej_Button)
        Controls.Add(ICO_TextBox)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 5, 4, 5)
        Name = "ARES_Form"
        Text = "ARES Searcher"
        Vysledek_GroupBox.ResumeLayout(False)
        Vysledek_GroupBox.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ICO_TextBox As TextBox
    Friend WithEvents Hledej_Button As Button
    Friend WithEvents ZadejICO_Label As Label
    Friend WithEvents Vysledek_GroupBox As GroupBox
    Friend WithEvents Vysledek_Label As Label
    Friend WithEvents Vysledek_TextBox As TextBox
    Friend WithEvents Chyba_Label As Label

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewConversionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CurrencyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolumeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SurfaceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseConveersionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenConversionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveConversionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"CENTIMETER (CUBE)", "METER (CUBE)", "KILOMETER (CUBE)", "PINT"})
        Me.ComboBox1.Location = New System.Drawing.Point(17, 151)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(168, 21)
        Me.ComboBox1.TabIndex = 13
        Me.ComboBox1.Text = "INPUT TYPE"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.RedoToolStripMenuItem.Text = "Redo"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(191, 151)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(128, 20)
        Me.TextBox1.TabIndex = 15
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"CENTIMETER (CUBE)", "METER (CUBE)", "KILOMETER (CUBE)", "PINT"})
        Me.ComboBox2.Location = New System.Drawing.Point(17, 237)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(168, 21)
        Me.ComboBox2.TabIndex = 14
        Me.ComboBox2.Text = "OUTPUT TYPE"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.CutToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'NewConversionToolStripMenuItem
        '
        Me.NewConversionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CurrencyToolStripMenuItem, Me.VolumeToolStripMenuItem, Me.SurfaceToolStripMenuItem})
        Me.NewConversionToolStripMenuItem.Name = "NewConversionToolStripMenuItem"
        Me.NewConversionToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.NewConversionToolStripMenuItem.Text = "New conversion"
        '
        'CurrencyToolStripMenuItem
        '
        Me.CurrencyToolStripMenuItem.Name = "CurrencyToolStripMenuItem"
        Me.CurrencyToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.CurrencyToolStripMenuItem.Text = "Currency"
        '
        'VolumeToolStripMenuItem
        '
        Me.VolumeToolStripMenuItem.Name = "VolumeToolStripMenuItem"
        Me.VolumeToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.VolumeToolStripMenuItem.Text = "Volume"
        '
        'SurfaceToolStripMenuItem
        '
        Me.SurfaceToolStripMenuItem.Name = "SurfaceToolStripMenuItem"
        Me.SurfaceToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.SurfaceToolStripMenuItem.Text = "Surface"
        '
        'CloseConveersionToolStripMenuItem
        '
        Me.CloseConveersionToolStripMenuItem.Name = "CloseConveersionToolStripMenuItem"
        Me.CloseConveersionToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.CloseConveersionToolStripMenuItem.Text = "Close conveersion"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewConversionToolStripMenuItem, Me.OpenConversionToolStripMenuItem, Me.SaveConversionToolStripMenuItem, Me.CloseConveersionToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenConversionToolStripMenuItem
        '
        Me.OpenConversionToolStripMenuItem.Name = "OpenConversionToolStripMenuItem"
        Me.OpenConversionToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.OpenConversionToolStripMenuItem.Text = "Open conversion"
        '
        'SaveConversionToolStripMenuItem
        '
        Me.SaveConversionToolStripMenuItem.Name = "SaveConversionToolStripMenuItem"
        Me.SaveConversionToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.SaveConversionToolStripMenuItem.Text = "Save conversion"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(459, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(191, 237)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(128, 20)
        Me.TextBox2.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(355, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 35)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Logout"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 312)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TextBox2)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewConversionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CurrencyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VolumeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SurfaceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseConveersionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenConversionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveConversionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

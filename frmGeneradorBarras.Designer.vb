<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGeneradorBarras
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGeneradorBarras))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Muestra = New System.Windows.Forms.PictureBox()
        Me.CodigoBarra = New MyBarcode.EAN13Barcode()
        Me.NombreArchivo = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.BtnGenerar = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtinicio = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtfinal = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ep = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Muestra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(423, 24)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "&Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercadeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ay&uda"
        '
        'AcercadeToolStripMenuItem
        '
        Me.AcercadeToolStripMenuItem.Name = "AcercadeToolStripMenuItem"
        Me.AcercadeToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AcercadeToolStripMenuItem.Text = "&Acerca de..."
        '
        'Muestra
        '
        Me.Muestra.BackColor = System.Drawing.Color.White
        Me.Muestra.Location = New System.Drawing.Point(420, 30)
        Me.Muestra.Name = "Muestra"
        Me.Muestra.Size = New System.Drawing.Size(194, 149)
        Me.Muestra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Muestra.TabIndex = 11
        Me.Muestra.TabStop = False
        '
        'CodigoBarra
        '
        Me.CodigoBarra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CodigoBarra.BackColor = System.Drawing.Color.White
        Me.CodigoBarra.BarHeight = 0.0R
        Me.CodigoBarra.BarWidth = 0.0R
        Me.CodigoBarra.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodigoBarra.Location = New System.Drawing.Point(214, 26)
        Me.CodigoBarra.Margin = New System.Windows.Forms.Padding(0)
        Me.CodigoBarra.Name = "CodigoBarra"
        Me.CodigoBarra.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CodigoBarra.ShowBarcodeText = True
        Me.CodigoBarra.ShowCheckSum = True
        Me.CodigoBarra.Size = New System.Drawing.Size(197, 142)
        Me.CodigoBarra.TabIndex = 4
        Me.CodigoBarra.Value = "000000000000"
        '
        'NombreArchivo
        '
        Me.NombreArchivo.Location = New System.Drawing.Point(4, 127)
        Me.NombreArchivo.Name = "NombreArchivo"
        Me.NombreArchivo.Size = New System.Drawing.Size(17, 20)
        Me.NombreArchivo.TabIndex = 24
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 190)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(423, 22)
        Me.StatusStrip1.TabIndex = 25
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'BtnGenerar
        '
        Me.BtnGenerar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BtnGenerar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BtnGenerar.Location = New System.Drawing.Point(46, 124)
        Me.BtnGenerar.Name = "BtnGenerar"
        Me.BtnGenerar.Size = New System.Drawing.Size(154, 23)
        Me.BtnGenerar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BtnGenerar.TabIndex = 30
        Me.BtnGenerar.Text = "Generar Secuencia"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(11, 72)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(29, 23)
        Me.LabelX1.TabIndex = 31
        Me.LabelX1.Text = "Inicio"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(11, 95)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(29, 23)
        Me.LabelX2.TabIndex = 32
        Me.LabelX2.Text = "Final"
        '
        'txtinicio
        '
        '
        '
        '
        Me.txtinicio.Border.Class = "TextBoxBorder"
        Me.txtinicio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtinicio.Location = New System.Drawing.Point(46, 72)
        Me.txtinicio.Name = "txtinicio"
        Me.txtinicio.Size = New System.Drawing.Size(154, 20)
        Me.txtinicio.TabIndex = 33
        '
        'txtfinal
        '
        '
        '
        '
        Me.txtfinal.Border.Class = "TextBoxBorder"
        Me.txtfinal.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtfinal.Location = New System.Drawing.Point(46, 95)
        Me.txtfinal.Name = "txtfinal"
        Me.txtfinal.Size = New System.Drawing.Size(154, 20)
        Me.txtfinal.TabIndex = 34
        '
        'ep
        '
        Me.ep.ContainerControl = Me
        '
        'frmGeneradorBarras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(423, 212)
        Me.Controls.Add(Me.txtfinal)
        Me.Controls.Add(Me.txtinicio)
        Me.Controls.Add(Me.LabelX2)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.BtnGenerar)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.NombreArchivo)
        Me.Controls.Add(Me.CodigoBarra)
        Me.Controls.Add(Me.Muestra)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(439, 250)
        Me.MinimumSize = New System.Drawing.Size(439, 250)
        Me.Name = "frmGeneradorBarras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Credenciales - Generador de Barras Secuencial"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Muestra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Muestra As System.Windows.Forms.PictureBox
    Friend WithEvents CodigoBarra As MyBarcode.EAN13Barcode
    Friend WithEvents NombreArchivo As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents BtnGenerar As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtinicio As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtfinal As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ep As System.Windows.Forms.ErrorProvider

End Class

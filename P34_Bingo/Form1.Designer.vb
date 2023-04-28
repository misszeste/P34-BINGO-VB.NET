<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form1
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
        Me.components = New System.ComponentModel.Container()
        Me.lblPrenon = New System.Windows.Forms.Label()
        Me.btnJouer = New System.Windows.Forms.Button()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.carteBingo = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelN5 = New System.Windows.Forms.Label()
        Me.LabelI5 = New System.Windows.Forms.Label()
        Me.LabelB5 = New System.Windows.Forms.Label()
        Me.LabelG4 = New System.Windows.Forms.Label()
        Me.LabelN4 = New System.Windows.Forms.Label()
        Me.LabelI4 = New System.Windows.Forms.Label()
        Me.LabelB4 = New System.Windows.Forms.Label()
        Me.LabelG3 = New System.Windows.Forms.Label()
        Me.LabelN3 = New System.Windows.Forms.Label()
        Me.LabelI3 = New System.Windows.Forms.Label()
        Me.LabelB3 = New System.Windows.Forms.Label()
        Me.LabelO2 = New System.Windows.Forms.Label()
        Me.LabelN2 = New System.Windows.Forms.Label()
        Me.LabelI2 = New System.Windows.Forms.Label()
        Me.LabelB2 = New System.Windows.Forms.Label()
        Me.LabelO1 = New System.Windows.Forms.Label()
        Me.LabelG1 = New System.Windows.Forms.Label()
        Me.LabelN1 = New System.Windows.Forms.Label()
        Me.LabelI1 = New System.Windows.Forms.Label()
        Me.LabelB1 = New System.Windows.Forms.Label()
        Me.LabelG2 = New System.Windows.Forms.Label()
        Me.LabelO4 = New System.Windows.Forms.Label()
        Me.LabelG5 = New System.Windows.Forms.Label()
        Me.LabelO3 = New System.Windows.Forms.Label()
        Me.LabelO5 = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblI = New System.Windows.Forms.Label()
        Me.lblN = New System.Windows.Forms.Label()
        Me.lblG = New System.Windows.Forms.Label()
        Me.lblO = New System.Windows.Forms.Label()
        Me.lblBoulier = New System.Windows.Forms.Label()
        Me.lblNbrJoueur = New System.Windows.Forms.Label()
        Me.NumericUpDownJoueur = New System.Windows.Forms.NumericUpDown()
        Me.Lbl_Mode = New System.Windows.Forms.Label()
        Me.RdbNormal = New System.Windows.Forms.RadioButton()
        Me.RdbPleine = New System.Windows.Forms.RadioButton()
        Me.Rdb4Coins = New System.Windows.Forms.RadioButton()
        Me.GroupBoxBingo = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBoxNbrBingo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Boulier = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.carteBingo.SuspendLayout()
        CType(Me.NumericUpDownJoueur, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxBingo.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPrenon
        '
        Me.lblPrenon.AutoSize = True
        Me.lblPrenon.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblPrenon.Location = New System.Drawing.Point(5, 42)
        Me.lblPrenon.Name = "lblPrenon"
        Me.lblPrenon.Size = New System.Drawing.Size(85, 25)
        Me.lblPrenon.TabIndex = 1
        Me.lblPrenon.Text = "Bonjour"
        '
        'btnJouer
        '
        Me.btnJouer.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnJouer.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnJouer.Location = New System.Drawing.Point(131, 359)
        Me.btnJouer.Name = "btnJouer"
        Me.btnJouer.Size = New System.Drawing.Size(93, 37)
        Me.btnJouer.TabIndex = 2
        Me.btnJouer.Text = "Jouer"
        Me.btnJouer.UseVisualStyleBackColor = False
        '
        'btnQuitter
        '
        Me.btnQuitter.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnQuitter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnQuitter.Location = New System.Drawing.Point(1235, 578)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(100, 37)
        Me.btnQuitter.TabIndex = 3
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = False
        '
        'carteBingo
        '
        Me.carteBingo.AllowDrop = True
        Me.carteBingo.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.carteBingo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.carteBingo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble
        Me.carteBingo.ColumnCount = 5
        Me.carteBingo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.carteBingo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.carteBingo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.carteBingo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.carteBingo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.carteBingo.Controls.Add(Me.LabelN5, 2, 4)
        Me.carteBingo.Controls.Add(Me.LabelI5, 1, 4)
        Me.carteBingo.Controls.Add(Me.LabelB5, 0, 4)
        Me.carteBingo.Controls.Add(Me.LabelG4, 3, 3)
        Me.carteBingo.Controls.Add(Me.LabelN4, 2, 3)
        Me.carteBingo.Controls.Add(Me.LabelI4, 1, 3)
        Me.carteBingo.Controls.Add(Me.LabelB4, 0, 3)
        Me.carteBingo.Controls.Add(Me.LabelG3, 3, 2)
        Me.carteBingo.Controls.Add(Me.LabelN3, 2, 2)
        Me.carteBingo.Controls.Add(Me.LabelI3, 1, 2)
        Me.carteBingo.Controls.Add(Me.LabelB3, 0, 2)
        Me.carteBingo.Controls.Add(Me.LabelO2, 4, 1)
        Me.carteBingo.Controls.Add(Me.LabelN2, 2, 1)
        Me.carteBingo.Controls.Add(Me.LabelI2, 1, 1)
        Me.carteBingo.Controls.Add(Me.LabelB2, 0, 1)
        Me.carteBingo.Controls.Add(Me.LabelO1, 4, 0)
        Me.carteBingo.Controls.Add(Me.LabelG1, 3, 0)
        Me.carteBingo.Controls.Add(Me.LabelN1, 2, 0)
        Me.carteBingo.Controls.Add(Me.LabelI1, 1, 0)
        Me.carteBingo.Controls.Add(Me.LabelB1, 0, 0)
        Me.carteBingo.Controls.Add(Me.LabelG2, 3, 1)
        Me.carteBingo.Controls.Add(Me.LabelO4, 4, 3)
        Me.carteBingo.Controls.Add(Me.LabelG5, 3, 4)
        Me.carteBingo.Controls.Add(Me.LabelO3, 4, 2)
        Me.carteBingo.Controls.Add(Me.LabelO5, 4, 4)
        Me.carteBingo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.carteBingo.Location = New System.Drawing.Point(895, 52)
        Me.carteBingo.Name = "carteBingo"
        Me.carteBingo.RowCount = 5
        Me.carteBingo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.94595!))
        Me.carteBingo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.91892!))
        Me.carteBingo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.carteBingo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.carteBingo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.carteBingo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.carteBingo.Size = New System.Drawing.Size(518, 436)
        Me.carteBingo.TabIndex = 8
        '
        'LabelN5
        '
        Me.LabelN5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelN5.AutoSize = True
        Me.LabelN5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelN5.Location = New System.Drawing.Point(212, 347)
        Me.LabelN5.Name = "LabelN5"
        Me.LabelN5.Size = New System.Drawing.Size(94, 86)
        Me.LabelN5.TabIndex = 22
        Me.LabelN5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelI5
        '
        Me.LabelI5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelI5.AutoSize = True
        Me.LabelI5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelI5.Location = New System.Drawing.Point(109, 347)
        Me.LabelI5.Name = "LabelI5"
        Me.LabelI5.Size = New System.Drawing.Size(94, 86)
        Me.LabelI5.TabIndex = 21
        Me.LabelI5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelB5
        '
        Me.LabelB5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelB5.AutoSize = True
        Me.LabelB5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelB5.Location = New System.Drawing.Point(6, 347)
        Me.LabelB5.Name = "LabelB5"
        Me.LabelB5.Size = New System.Drawing.Size(94, 86)
        Me.LabelB5.TabIndex = 20
        Me.LabelB5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelG4
        '
        Me.LabelG4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelG4.AutoSize = True
        Me.LabelG4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelG4.Location = New System.Drawing.Point(315, 261)
        Me.LabelG4.Name = "LabelG4"
        Me.LabelG4.Size = New System.Drawing.Size(94, 83)
        Me.LabelG4.TabIndex = 18
        Me.LabelG4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelN4
        '
        Me.LabelN4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelN4.AutoSize = True
        Me.LabelN4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelN4.Location = New System.Drawing.Point(212, 261)
        Me.LabelN4.Name = "LabelN4"
        Me.LabelN4.Size = New System.Drawing.Size(94, 83)
        Me.LabelN4.TabIndex = 17
        Me.LabelN4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelI4
        '
        Me.LabelI4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelI4.AutoSize = True
        Me.LabelI4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelI4.Location = New System.Drawing.Point(109, 261)
        Me.LabelI4.Name = "LabelI4"
        Me.LabelI4.Size = New System.Drawing.Size(94, 83)
        Me.LabelI4.TabIndex = 16
        Me.LabelI4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelB4
        '
        Me.LabelB4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelB4.AutoSize = True
        Me.LabelB4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelB4.Location = New System.Drawing.Point(6, 261)
        Me.LabelB4.Name = "LabelB4"
        Me.LabelB4.Size = New System.Drawing.Size(94, 83)
        Me.LabelB4.TabIndex = 15
        Me.LabelB4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelG3
        '
        Me.LabelG3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelG3.AutoSize = True
        Me.LabelG3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelG3.Location = New System.Drawing.Point(315, 175)
        Me.LabelG3.Name = "LabelG3"
        Me.LabelG3.Size = New System.Drawing.Size(94, 83)
        Me.LabelG3.TabIndex = 13
        Me.LabelG3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelN3
        '
        Me.LabelN3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelN3.AutoSize = True
        Me.LabelN3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelN3.Location = New System.Drawing.Point(212, 175)
        Me.LabelN3.Name = "LabelN3"
        Me.LabelN3.Size = New System.Drawing.Size(94, 83)
        Me.LabelN3.TabIndex = 12
        Me.LabelN3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelI3
        '
        Me.LabelI3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelI3.AutoSize = True
        Me.LabelI3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelI3.Location = New System.Drawing.Point(109, 175)
        Me.LabelI3.Name = "LabelI3"
        Me.LabelI3.Size = New System.Drawing.Size(94, 83)
        Me.LabelI3.TabIndex = 11
        Me.LabelI3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelB3
        '
        Me.LabelB3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelB3.AutoSize = True
        Me.LabelB3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelB3.Location = New System.Drawing.Point(6, 175)
        Me.LabelB3.Name = "LabelB3"
        Me.LabelB3.Size = New System.Drawing.Size(94, 83)
        Me.LabelB3.TabIndex = 10
        Me.LabelB3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelO2
        '
        Me.LabelO2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelO2.AutoSize = True
        Me.LabelO2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelO2.Location = New System.Drawing.Point(418, 93)
        Me.LabelO2.Name = "LabelO2"
        Me.LabelO2.Size = New System.Drawing.Size(94, 79)
        Me.LabelO2.TabIndex = 9
        Me.LabelO2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelN2
        '
        Me.LabelN2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelN2.AutoSize = True
        Me.LabelN2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelN2.Location = New System.Drawing.Point(212, 93)
        Me.LabelN2.Name = "LabelN2"
        Me.LabelN2.Size = New System.Drawing.Size(94, 79)
        Me.LabelN2.TabIndex = 7
        Me.LabelN2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelI2
        '
        Me.LabelI2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelI2.AutoSize = True
        Me.LabelI2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelI2.Location = New System.Drawing.Point(109, 93)
        Me.LabelI2.Name = "LabelI2"
        Me.LabelI2.Size = New System.Drawing.Size(94, 79)
        Me.LabelI2.TabIndex = 6
        Me.LabelI2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelB2
        '
        Me.LabelB2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelB2.AutoSize = True
        Me.LabelB2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelB2.Location = New System.Drawing.Point(6, 93)
        Me.LabelB2.Name = "LabelB2"
        Me.LabelB2.Size = New System.Drawing.Size(94, 79)
        Me.LabelB2.TabIndex = 5
        Me.LabelB2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelO1
        '
        Me.LabelO1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelO1.AutoSize = True
        Me.LabelO1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelO1.Location = New System.Drawing.Point(418, 3)
        Me.LabelO1.Name = "LabelO1"
        Me.LabelO1.Size = New System.Drawing.Size(94, 87)
        Me.LabelO1.TabIndex = 4
        Me.LabelO1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelG1
        '
        Me.LabelG1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelG1.AutoSize = True
        Me.LabelG1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelG1.Location = New System.Drawing.Point(315, 3)
        Me.LabelG1.Name = "LabelG1"
        Me.LabelG1.Size = New System.Drawing.Size(94, 87)
        Me.LabelG1.TabIndex = 3
        Me.LabelG1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelN1
        '
        Me.LabelN1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelN1.AutoSize = True
        Me.LabelN1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelN1.Location = New System.Drawing.Point(212, 3)
        Me.LabelN1.Name = "LabelN1"
        Me.LabelN1.Size = New System.Drawing.Size(94, 87)
        Me.LabelN1.TabIndex = 2
        Me.LabelN1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelI1
        '
        Me.LabelI1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelI1.AutoSize = True
        Me.LabelI1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelI1.Location = New System.Drawing.Point(109, 3)
        Me.LabelI1.Name = "LabelI1"
        Me.LabelI1.Size = New System.Drawing.Size(94, 87)
        Me.LabelI1.TabIndex = 1
        Me.LabelI1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelB1
        '
        Me.LabelB1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelB1.AutoSize = True
        Me.LabelB1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelB1.Location = New System.Drawing.Point(6, 3)
        Me.LabelB1.Name = "LabelB1"
        Me.LabelB1.Size = New System.Drawing.Size(94, 87)
        Me.LabelB1.TabIndex = 0
        Me.LabelB1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelG2
        '
        Me.LabelG2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelG2.AutoSize = True
        Me.LabelG2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelG2.Location = New System.Drawing.Point(315, 93)
        Me.LabelG2.Name = "LabelG2"
        Me.LabelG2.Size = New System.Drawing.Size(94, 79)
        Me.LabelG2.TabIndex = 8
        Me.LabelG2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelO4
        '
        Me.LabelO4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelO4.AutoSize = True
        Me.LabelO4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelO4.Location = New System.Drawing.Point(418, 261)
        Me.LabelO4.Name = "LabelO4"
        Me.LabelO4.Size = New System.Drawing.Size(94, 83)
        Me.LabelO4.TabIndex = 19
        Me.LabelO4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelG5
        '
        Me.LabelG5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelG5.AutoSize = True
        Me.LabelG5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelG5.Location = New System.Drawing.Point(315, 347)
        Me.LabelG5.Name = "LabelG5"
        Me.LabelG5.Size = New System.Drawing.Size(94, 86)
        Me.LabelG5.TabIndex = 23
        Me.LabelG5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelO3
        '
        Me.LabelO3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelO3.AutoSize = True
        Me.LabelO3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelO3.Location = New System.Drawing.Point(418, 175)
        Me.LabelO3.Name = "LabelO3"
        Me.LabelO3.Size = New System.Drawing.Size(94, 83)
        Me.LabelO3.TabIndex = 14
        Me.LabelO3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelO5
        '
        Me.LabelO5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelO5.AutoSize = True
        Me.LabelO5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelO5.Location = New System.Drawing.Point(418, 347)
        Me.LabelO5.Name = "LabelO5"
        Me.LabelO5.Size = New System.Drawing.Size(94, 86)
        Me.LabelO5.TabIndex = 24
        Me.LabelO5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblB.Location = New System.Drawing.Point(937, 23)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(24, 25)
        Me.lblB.TabIndex = 9
        Me.lblB.Text = "B"
        '
        'lblI
        '
        Me.lblI.AutoSize = True
        Me.lblI.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblI.Location = New System.Drawing.Point(1044, 23)
        Me.lblI.Name = "lblI"
        Me.lblI.Size = New System.Drawing.Size(18, 25)
        Me.lblI.TabIndex = 10
        Me.lblI.Text = "I"
        '
        'lblN
        '
        Me.lblN.AutoSize = True
        Me.lblN.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblN.Location = New System.Drawing.Point(1143, 23)
        Me.lblN.Name = "lblN"
        Me.lblN.Size = New System.Drawing.Size(27, 25)
        Me.lblN.TabIndex = 11
        Me.lblN.Text = "N"
        '
        'lblG
        '
        Me.lblG.AutoSize = True
        Me.lblG.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblG.Location = New System.Drawing.Point(1248, 23)
        Me.lblG.Name = "lblG"
        Me.lblG.Size = New System.Drawing.Size(26, 25)
        Me.lblG.TabIndex = 12
        Me.lblG.Text = "G"
        '
        'lblO
        '
        Me.lblO.AutoSize = True
        Me.lblO.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblO.Location = New System.Drawing.Point(1351, 23)
        Me.lblO.Name = "lblO"
        Me.lblO.Size = New System.Drawing.Size(26, 25)
        Me.lblO.TabIndex = 13
        Me.lblO.Text = "O"
        '
        'lblBoulier
        '
        Me.lblBoulier.AutoSize = True
        Me.lblBoulier.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblBoulier.Location = New System.Drawing.Point(632, 28)
        Me.lblBoulier.Name = "lblBoulier"
        Me.lblBoulier.Size = New System.Drawing.Size(76, 25)
        Me.lblBoulier.TabIndex = 5
        Me.lblBoulier.Text = "Boulier"
        '
        'lblNbrJoueur
        '
        Me.lblNbrJoueur.AutoSize = True
        Me.lblNbrJoueur.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNbrJoueur.Location = New System.Drawing.Point(5, 102)
        Me.lblNbrJoueur.Name = "lblNbrJoueur"
        Me.lblNbrJoueur.Size = New System.Drawing.Size(158, 21)
        Me.lblNbrJoueur.TabIndex = 6
        Me.lblNbrJoueur.Text = "Nombre de joueur :"
        '
        'NumericUpDownJoueur
        '
        Me.NumericUpDownJoueur.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.NumericUpDownJoueur.Location = New System.Drawing.Point(227, 91)
        Me.NumericUpDownJoueur.Margin = New System.Windows.Forms.Padding(6)
        Me.NumericUpDownJoueur.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.NumericUpDownJoueur.Minimum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.NumericUpDownJoueur.Name = "NumericUpDownJoueur"
        Me.NumericUpDownJoueur.Size = New System.Drawing.Size(156, 29)
        Me.NumericUpDownJoueur.TabIndex = 7
        Me.NumericUpDownJoueur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDownJoueur.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Lbl_Mode
        '
        Me.Lbl_Mode.AutoSize = True
        Me.Lbl_Mode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Lbl_Mode.Location = New System.Drawing.Point(5, 156)
        Me.Lbl_Mode.Name = "Lbl_Mode"
        Me.Lbl_Mode.Size = New System.Drawing.Size(282, 21)
        Me.Lbl_Mode.TabIndex = 14
        Me.Lbl_Mode.Text = "Quel est votre mode de jeux désiré :"
        '
        'RdbNormal
        '
        Me.RdbNormal.AutoSize = True
        Me.RdbNormal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RdbNormal.Location = New System.Drawing.Point(25, 205)
        Me.RdbNormal.Name = "RdbNormal"
        Me.RdbNormal.Size = New System.Drawing.Size(357, 25)
        Me.RdbNormal.TabIndex = 15
        Me.RdbNormal.TabStop = True
        Me.RdbNormal.Text = "Mode normal : ligne, colonne ou diagonale"
        Me.RdbNormal.UseVisualStyleBackColor = True
        '
        'RdbPleine
        '
        Me.RdbPleine.AutoSize = True
        Me.RdbPleine.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RdbPleine.Location = New System.Drawing.Point(25, 240)
        Me.RdbPleine.Name = "RdbPleine"
        Me.RdbPleine.Size = New System.Drawing.Size(166, 25)
        Me.RdbPleine.TabIndex = 16
        Me.RdbPleine.TabStop = True
        Me.RdbPleine.Text = "Mode carte pleine"
        Me.RdbPleine.UseVisualStyleBackColor = True
        '
        'Rdb4Coins
        '
        Me.Rdb4Coins.AutoSize = True
        Me.Rdb4Coins.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Rdb4Coins.Location = New System.Drawing.Point(25, 279)
        Me.Rdb4Coins.Name = "Rdb4Coins"
        Me.Rdb4Coins.Size = New System.Drawing.Size(129, 25)
        Me.Rdb4Coins.TabIndex = 17
        Me.Rdb4Coins.TabStop = True
        Me.Rdb4Coins.Text = "Mode 4 coins"
        Me.Rdb4Coins.UseVisualStyleBackColor = True
        '
        'GroupBoxBingo
        '
        Me.GroupBoxBingo.AutoSize = True
        Me.GroupBoxBingo.BackColor = System.Drawing.Color.SlateBlue
        Me.GroupBoxBingo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBoxBingo.Controls.Add(Me.Label8)
        Me.GroupBoxBingo.Controls.Add(Me.txtBoxNbrBingo)
        Me.GroupBoxBingo.Controls.Add(Me.Label6)
        Me.GroupBoxBingo.Controls.Add(Me.Label5)
        Me.GroupBoxBingo.Controls.Add(Me.Label4)
        Me.GroupBoxBingo.Controls.Add(Me.Label3)
        Me.GroupBoxBingo.Controls.Add(Me.Label7)
        Me.GroupBoxBingo.Controls.Add(Me.Boulier)
        Me.GroupBoxBingo.Controls.Add(Me.lblBoulier)
        Me.GroupBoxBingo.Controls.Add(Me.Rdb4Coins)
        Me.GroupBoxBingo.Controls.Add(Me.btnQuitter)
        Me.GroupBoxBingo.Controls.Add(Me.RdbPleine)
        Me.GroupBoxBingo.Controls.Add(Me.RdbNormal)
        Me.GroupBoxBingo.Controls.Add(Me.carteBingo)
        Me.GroupBoxBingo.Controls.Add(Me.Lbl_Mode)
        Me.GroupBoxBingo.Controls.Add(Me.lblB)
        Me.GroupBoxBingo.Controls.Add(Me.NumericUpDownJoueur)
        Me.GroupBoxBingo.Controls.Add(Me.lblO)
        Me.GroupBoxBingo.Controls.Add(Me.lblNbrJoueur)
        Me.GroupBoxBingo.Controls.Add(Me.lblI)
        Me.GroupBoxBingo.Controls.Add(Me.btnJouer)
        Me.GroupBoxBingo.Controls.Add(Me.lblG)
        Me.GroupBoxBingo.Controls.Add(Me.lblPrenon)
        Me.GroupBoxBingo.Controls.Add(Me.lblN)
        Me.GroupBoxBingo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBoxBingo.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBoxBingo.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxBingo.Name = "GroupBoxBingo"
        Me.GroupBoxBingo.Size = New System.Drawing.Size(1423, 650)
        Me.GroupBoxBingo.TabIndex = 18
        Me.GroupBoxBingo.TabStop = False
        Me.GroupBoxBingo.Text = "Votre Bingo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(43, 486)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(209, 30)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Nombre de BINGO :"
        '
        'txtBoxNbrBingo
        '
        Me.txtBoxNbrBingo.Location = New System.Drawing.Point(283, 480)
        Me.txtBoxNbrBingo.Name = "txtBoxNbrBingo"
        Me.txtBoxNbrBingo.Size = New System.Drawing.Size(100, 36)
        Me.txtBoxNbrBingo.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(801, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 25)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "O"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(729, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 25)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "G"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(586, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 25)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "I"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(512, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 25)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "B"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(659, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 25)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "N"
        '
        'Boulier
        '
        Me.Boulier.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Boulier.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble
        Me.Boulier.ColumnCount = 5
        Me.Boulier.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Boulier.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Boulier.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Boulier.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Boulier.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Boulier.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Boulier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Boulier.Location = New System.Drawing.Point(486, 94)
        Me.Boulier.Name = "Boulier"
        Me.Boulier.RowCount = 15
        Me.Boulier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667!))
        Me.Boulier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667!))
        Me.Boulier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667!))
        Me.Boulier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667!))
        Me.Boulier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667!))
        Me.Boulier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667!))
        Me.Boulier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667!))
        Me.Boulier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667!))
        Me.Boulier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667!))
        Me.Boulier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667!))
        Me.Boulier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667!))
        Me.Boulier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667!))
        Me.Boulier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667!))
        Me.Boulier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667!))
        Me.Boulier.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667!))
        Me.Boulier.Size = New System.Drawing.Size(369, 351)
        Me.Boulier.TabIndex = 18
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AllowDrop = True
        Me.TableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 2, 4)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(200, 100)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(84, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 20)
        Me.Label1.TabIndex = 22
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(45, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 82)
        Me.Label2.TabIndex = 21
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ClientSize = New System.Drawing.Size(1447, 673)
        Me.Controls.Add(Me.GroupBoxBingo)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "form1"
        Me.Text = "Jeux de Bingo"
        Me.carteBingo.ResumeLayout(False)
        Me.carteBingo.PerformLayout()
        CType(Me.NumericUpDownJoueur, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxBingo.ResumeLayout(False)
        Me.GroupBoxBingo.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrenon As Label
    Friend WithEvents btnJouer As Button
    Friend WithEvents btnQuitter As Button
    Friend WithEvents carteBingo As TableLayoutPanel
    Friend WithEvents lblB As Label
    Friend WithEvents lblI As Label
    Friend WithEvents lblN As Label
    Friend WithEvents lblG As Label
    Friend WithEvents lblO As Label
    Friend WithEvents LabelO5 As Label
    Friend WithEvents LabelG5 As Label
    Friend WithEvents LabelN5 As Label
    Friend WithEvents LabelI5 As Label
    Friend WithEvents LabelB5 As Label
    Friend WithEvents LabelO4 As Label
    Friend WithEvents LabelG4 As Label
    Friend WithEvents LabelN4 As Label
    Friend WithEvents LabelI4 As Label
    Friend WithEvents LabelB4 As Label
    Friend WithEvents LabelO3 As Label
    Friend WithEvents LabelG3 As Label
    Friend WithEvents LabelN3 As Label
    Friend WithEvents LabelI3 As Label
    Friend WithEvents LabelB3 As Label
    Friend WithEvents LabelO2 As Label
    Friend WithEvents LabelN2 As Label
    Friend WithEvents LabelI2 As Label
    Friend WithEvents LabelB2 As Label
    Friend WithEvents LabelO1 As Label
    Friend WithEvents LabelG1 As Label
    Friend WithEvents LabelN1 As Label
    Friend WithEvents LabelI1 As Label
    Friend WithEvents LabelB1 As Label
    Friend WithEvents LabelG2 As Label
    Friend WithEvents lblBoulier As Label
    Friend WithEvents lblNbrJoueur As Label
    Friend WithEvents NumericUpDownJoueur As NumericUpDown
    Friend WithEvents Lbl_Mode As Label
    Friend WithEvents RdbNormal As RadioButton
    Friend WithEvents RdbPleine As RadioButton
    Friend WithEvents Rdb4Coins As RadioButton
    Friend WithEvents GroupBoxBingo As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Boulier As TableLayoutPanel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label8 As Label
    Friend WithEvents txtBoxNbrBingo As TextBox
End Class

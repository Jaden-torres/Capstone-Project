<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Title = New Label()
        Location = New Label()
        Start = New Button()
        Slogan = New Label()
        Background = New GroupBox()
        PictureBox2 = New PictureBox()
        ExitBttn = New Button()
        GoBack = New Button()
        WingCount = New Label()
        TenWings = New RadioButton()
        FifteenWings = New RadioButton()
        TwentyWings = New RadioButton()
        Ignore = New RadioButton()
        NextBttn = New Button()
        GroupOne = New GroupBox()
        GroupTwo = New GroupBox()
        GroupThree = New GroupBox()
        IDC = New RadioButton()
        Flats = New RadioButton()
        Drums = New RadioButton()
        WingType = New Label()
        GroupFour = New GroupBox()
        IgnoreFlavor = New RadioButton()
        SplitFlavor = New CheckBox()
        GarlicParm = New RadioButton()
        LemonPepper = New RadioButton()
        SpicyBBQ = New RadioButton()
        Teriyaki = New RadioButton()
        BBQ = New RadioButton()
        Ouch = New RadioButton()
        Hot = New RadioButton()
        Medium = New RadioButton()
        Mild = New RadioButton()
        Plain = New RadioButton()
        Flavor = New Label()
        GroupFive = New GroupBox()
        IgnoreFry = New RadioButton()
        LargeFry = New RadioButton()
        RegFry = New RadioButton()
        NoFry = New RadioButton()
        FryTime = New Label()
        GroupNine = New GroupBox()
        Receipt = New GroupBox()
        TotBox = New GroupBox()
        SubBox = New GroupBox()
        Clear = New Button()
        Confirm = New Button()
        Total = New Label()
        SubTotal = New Label()
        Order = New Label()
        GroupSix = New GroupBox()
        IgnoreDrink = New RadioButton()
        LargeDrink = New RadioButton()
        RegularDrink = New RadioButton()
        NoDrink = New RadioButton()
        Thirsty = New Label()
        GroupSeven = New GroupBox()
        ComboBox1 = New ComboBox()
        Label3 = New Label()
        BlueCheeseBox = New ComboBox()
        Label2 = New Label()
        Label1 = New Label()
        RanchBox = New ComboBox()
        Sauce = New Label()
        GroupEight = New GroupBox()
        No = New Button()
        More = New Label()
        PictureBox1 = New PictureBox()
        ReceiptLBL = New Label()
        Background.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        GroupOne.SuspendLayout()
        GroupTwo.SuspendLayout()
        GroupThree.SuspendLayout()
        GroupFour.SuspendLayout()
        GroupFive.SuspendLayout()
        GroupNine.SuspendLayout()
        GroupSix.SuspendLayout()
        GroupSeven.SuspendLayout()
        GroupEight.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Title
        ' 
        Title.AutoSize = True
        Title.Font = New Font("Unispace", 35.9999962F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Title.Location = New Point(23, 7)
        Title.Margin = New Padding(4, 0, 4, 0)
        Title.Name = "Title"
        Title.Size = New Size(829, 86)
        Title.TabIndex = 0
        Title.Text = "Jaden's Wing World"
        ' 
        ' Location
        ' 
        Location.AutoSize = True
        Location.Font = New Font("Unispace", 15.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Location.Location = New Point(23, 93)
        Location.Margin = New Padding(4, 0, 4, 0)
        Location.Name = "Location"
        Location.Size = New Size(257, 39)
        Location.TabIndex = 1
        Location.Text = "Columbus, GA"
        ' 
        ' Start
        ' 
        Start.Font = New Font("Unispace", 15.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Start.Location = New Point(388, 133)
        Start.Name = "Start"
        Start.Size = New Size(344, 108)
        Start.TabIndex = 2
        Start.Text = "Start Here"
        Start.UseVisualStyleBackColor = True
        ' 
        ' Slogan
        ' 
        Slogan.AutoSize = True
        Slogan.Font = New Font("Unispace", 22.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Slogan.Location = New Point(253, 35)
        Slogan.Name = "Slogan"
        Slogan.Size = New Size(617, 53)
        Slogan.TabIndex = 3
        Slogan.Text = "The best wings in town"
        ' 
        ' Background
        ' 
        Background.BackColor = Color.DarkRed
        Background.Controls.Add(PictureBox2)
        Background.Controls.Add(Location)
        Background.Controls.Add(Title)
        Background.Location = New Point(1, 1)
        Background.Name = "Background"
        Background.Size = New Size(1255, 143)
        Background.TabIndex = 4
        Background.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(890, -15)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(428, 264)
        PictureBox2.TabIndex = 23
        PictureBox2.TabStop = False
        ' 
        ' ExitBttn
        ' 
        ExitBttn.Font = New Font("Unispace", 8.999999F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        ExitBttn.Location = New Point(1059, 708)
        ExitBttn.Name = "ExitBttn"
        ExitBttn.Size = New Size(152, 61)
        ExitBttn.TabIndex = 5
        ExitBttn.Text = "Exit"
        ExitBttn.UseVisualStyleBackColor = True
        ' 
        ' GoBack
        ' 
        GoBack.Font = New Font("Unispace", 8.999999F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        GoBack.Location = New Point(12, 708)
        GoBack.Name = "GoBack"
        GoBack.Size = New Size(152, 61)
        GoBack.TabIndex = 6
        GoBack.Text = "Go Back"
        GoBack.UseVisualStyleBackColor = True
        ' 
        ' WingCount
        ' 
        WingCount.AutoSize = True
        WingCount.Font = New Font("Unispace", 22.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        WingCount.Location = New Point(143, 43)
        WingCount.Name = "WingCount"
        WingCount.Size = New Size(887, 53)
        WingCount.TabIndex = 7
        WingCount.Text = "Lets start with your wing count:"
        ' 
        ' TenWings
        ' 
        TenWings.AutoSize = True
        TenWings.Font = New Font("Unispace", 15.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TenWings.Location = New Point(93, 161)
        TenWings.Name = "TenWings"
        TenWings.Size = New Size(202, 43)
        TenWings.TabIndex = 8
        TenWings.TabStop = True
        TenWings.Text = "10 Wings"
        TenWings.UseVisualStyleBackColor = True
        ' 
        ' FifteenWings
        ' 
        FifteenWings.AutoSize = True
        FifteenWings.Font = New Font("Unispace", 15.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        FifteenWings.Location = New Point(492, 161)
        FifteenWings.Name = "FifteenWings"
        FifteenWings.Size = New Size(202, 43)
        FifteenWings.TabIndex = 9
        FifteenWings.TabStop = True
        FifteenWings.Text = "15 Wings"
        FifteenWings.UseVisualStyleBackColor = True
        ' 
        ' TwentyWings
        ' 
        TwentyWings.AutoSize = True
        TwentyWings.Font = New Font("Unispace", 15.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        TwentyWings.Location = New Point(892, 161)
        TwentyWings.Name = "TwentyWings"
        TwentyWings.Size = New Size(202, 43)
        TwentyWings.TabIndex = 10
        TwentyWings.TabStop = True
        TwentyWings.Text = "20 Wings"
        TwentyWings.UseVisualStyleBackColor = True
        ' 
        ' Ignore
        ' 
        Ignore.AutoSize = True
        Ignore.Font = New Font("Unispace", 15.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Ignore.Location = New Point(41, 99)
        Ignore.Name = "Ignore"
        Ignore.Size = New Size(162, 43)
        Ignore.TabIndex = 11
        Ignore.TabStop = True
        Ignore.Text = "Ignore"
        Ignore.UseVisualStyleBackColor = True
        ' 
        ' NextBttn
        ' 
        NextBttn.Font = New Font("Unispace", 8.999999F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        NextBttn.Location = New Point(185, 708)
        NextBttn.Name = "NextBttn"
        NextBttn.Size = New Size(152, 61)
        NextBttn.TabIndex = 12
        NextBttn.Text = "Next"
        NextBttn.UseVisualStyleBackColor = True
        ' 
        ' GroupOne
        ' 
        GroupOne.Controls.Add(Slogan)
        GroupOne.Controls.Add(Start)
        GroupOne.Location = New Point(55, 235)
        GroupOne.Name = "GroupOne"
        GroupOne.Size = New Size(1157, 329)
        GroupOne.TabIndex = 13
        GroupOne.TabStop = False
        ' 
        ' GroupTwo
        ' 
        GroupTwo.Controls.Add(WingCount)
        GroupTwo.Controls.Add(TenWings)
        GroupTwo.Controls.Add(FifteenWings)
        GroupTwo.Controls.Add(TwentyWings)
        GroupTwo.Controls.Add(Ignore)
        GroupTwo.Location = New Point(55, 244)
        GroupTwo.Name = "GroupTwo"
        GroupTwo.Size = New Size(1199, 341)
        GroupTwo.TabIndex = 14
        GroupTwo.TabStop = False
        ' 
        ' GroupThree
        ' 
        GroupThree.Controls.Add(IDC)
        GroupThree.Controls.Add(Flats)
        GroupThree.Controls.Add(Drums)
        GroupThree.Controls.Add(WingType)
        GroupThree.Location = New Point(16, 238)
        GroupThree.Name = "GroupThree"
        GroupThree.Size = New Size(1243, 341)
        GroupThree.TabIndex = 15
        GroupThree.TabStop = False
        ' 
        ' IDC
        ' 
        IDC.AutoSize = True
        IDC.Font = New Font("Unispace", 15.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        IDC.Location = New Point(929, 153)
        IDC.Name = "IDC"
        IDC.Size = New Size(282, 43)
        IDC.TabIndex = 18
        IDC.TabStop = True
        IDC.Text = "I don't care"
        IDC.UseVisualStyleBackColor = True
        ' 
        ' Flats
        ' 
        Flats.AutoSize = True
        Flats.Font = New Font("Unispace", 15.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Flats.Location = New Point(485, 153)
        Flats.Name = "Flats"
        Flats.Size = New Size(362, 43)
        Flats.TabIndex = 17
        Flats.TabStop = True
        Flats.Text = "Flats  (+ $1.25)"
        Flats.UseVisualStyleBackColor = True
        ' 
        ' Drums
        ' 
        Drums.AutoSize = True
        Drums.Font = New Font("Unispace", 15.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Drums.Location = New Point(69, 153)
        Drums.Name = "Drums"
        Drums.Size = New Size(342, 43)
        Drums.TabIndex = 16
        Drums.TabStop = True
        Drums.Text = "Drums (+ $1.25)"
        Drums.UseVisualStyleBackColor = True
        ' 
        ' WingType
        ' 
        WingType.AutoSize = True
        WingType.Font = New Font("Unispace", 22.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        WingType.Location = New Point(158, 43)
        WingType.Name = "WingType"
        WingType.Size = New Size(914, 53)
        WingType.TabIndex = 8
        WingType.Text = "What type of wings do you prefer?"
        ' 
        ' GroupFour
        ' 
        GroupFour.Controls.Add(IgnoreFlavor)
        GroupFour.Controls.Add(SplitFlavor)
        GroupFour.Controls.Add(GarlicParm)
        GroupFour.Controls.Add(LemonPepper)
        GroupFour.Controls.Add(SpicyBBQ)
        GroupFour.Controls.Add(Teriyaki)
        GroupFour.Controls.Add(BBQ)
        GroupFour.Controls.Add(Ouch)
        GroupFour.Controls.Add(Hot)
        GroupFour.Controls.Add(Medium)
        GroupFour.Controls.Add(Mild)
        GroupFour.Controls.Add(Plain)
        GroupFour.Controls.Add(Flavor)
        GroupFour.Location = New Point(12, 210)
        GroupFour.Name = "GroupFour"
        GroupFour.Size = New Size(1229, 432)
        GroupFour.TabIndex = 16
        GroupFour.TabStop = False
        ' 
        ' IgnoreFlavor
        ' 
        IgnoreFlavor.AutoSize = True
        IgnoreFlavor.Location = New Point(135, 145)
        IgnoreFlavor.Name = "IgnoreFlavor"
        IgnoreFlavor.Size = New Size(169, 27)
        IgnoreFlavor.TabIndex = 23
        IgnoreFlavor.TabStop = True
        IgnoreFlavor.Text = "RadioButton1"
        IgnoreFlavor.UseVisualStyleBackColor = True
        ' 
        ' SplitFlavor
        ' 
        SplitFlavor.AutoSize = True
        SplitFlavor.Location = New Point(507, 99)
        SplitFlavor.Name = "SplitFlavor"
        SplitFlavor.Size = New Size(179, 27)
        SplitFlavor.TabIndex = 22
        SplitFlavor.Text = "Split a flavor?"
        SplitFlavor.UseVisualStyleBackColor = True
        ' 
        ' GarlicParm
        ' 
        GarlicParm.AutoSize = True
        GarlicParm.Font = New Font("Unispace", 15.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        GarlicParm.Location = New Point(679, 333)
        GarlicParm.Name = "GarlicParm"
        GarlicParm.Size = New Size(382, 43)
        GarlicParm.TabIndex = 17
        GarlicParm.TabStop = True
        GarlicParm.Text = "Garlic Parmensean"
        GarlicParm.UseVisualStyleBackColor = True
        ' 
        ' LemonPepper
        ' 
        LemonPepper.AutoSize = True
        LemonPepper.Font = New Font("Unispace", 15.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LemonPepper.Location = New Point(679, 284)
        LemonPepper.Name = "LemonPepper"
        LemonPepper.Size = New Size(282, 43)
        LemonPepper.TabIndex = 17
        LemonPepper.TabStop = True
        LemonPepper.Text = "Lemon Pepper"
        LemonPepper.UseVisualStyleBackColor = True
        ' 
        ' SpicyBBQ
        ' 
        SpicyBBQ.AutoSize = True
        SpicyBBQ.Font = New Font("Unispace", 15.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        SpicyBBQ.Location = New Point(679, 186)
        SpicyBBQ.Name = "SpicyBBQ"
        SpicyBBQ.Size = New Size(222, 43)
        SpicyBBQ.TabIndex = 21
        SpicyBBQ.TabStop = True
        SpicyBBQ.Text = "Spicy BBQ"
        SpicyBBQ.UseVisualStyleBackColor = True
        ' 
        ' Teriyaki
        ' 
        Teriyaki.AutoSize = True
        Teriyaki.Font = New Font("Unispace", 15.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Teriyaki.Location = New Point(679, 235)
        Teriyaki.Name = "Teriyaki"
        Teriyaki.Size = New Size(202, 43)
        Teriyaki.TabIndex = 17
        Teriyaki.TabStop = True
        Teriyaki.Text = "Teriyaki"
        Teriyaki.UseVisualStyleBackColor = True
        ' 
        ' BBQ
        ' 
        BBQ.AutoSize = True
        BBQ.Font = New Font("Unispace", 15.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        BBQ.Location = New Point(679, 137)
        BBQ.Name = "BBQ"
        BBQ.Size = New Size(102, 43)
        BBQ.TabIndex = 17
        BBQ.TabStop = True
        BBQ.Text = "BBQ"
        BBQ.UseVisualStyleBackColor = True
        ' 
        ' Ouch
        ' 
        Ouch.AutoSize = True
        Ouch.Font = New Font("Unispace", 15.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Ouch.Location = New Point(360, 331)
        Ouch.Name = "Ouch"
        Ouch.Size = New Size(142, 43)
        Ouch.TabIndex = 20
        Ouch.TabStop = True
        Ouch.Text = "Ouch!"
        Ouch.UseVisualStyleBackColor = True
        ' 
        ' Hot
        ' 
        Hot.AutoSize = True
        Hot.Font = New Font("Unispace", 15.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Hot.Location = New Point(360, 281)
        Hot.Name = "Hot"
        Hot.Size = New Size(102, 43)
        Hot.TabIndex = 19
        Hot.TabStop = True
        Hot.Text = "Hot"
        Hot.UseVisualStyleBackColor = True
        ' 
        ' Medium
        ' 
        Medium.AutoSize = True
        Medium.Font = New Font("Unispace", 15.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Medium.Location = New Point(360, 235)
        Medium.Name = "Medium"
        Medium.Size = New Size(162, 43)
        Medium.TabIndex = 17
        Medium.TabStop = True
        Medium.Text = "Medium"
        Medium.UseVisualStyleBackColor = True
        ' 
        ' Mild
        ' 
        Mild.AutoSize = True
        Mild.Font = New Font("Unispace", 15.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Mild.Location = New Point(360, 186)
        Mild.Name = "Mild"
        Mild.Size = New Size(122, 43)
        Mild.TabIndex = 17
        Mild.TabStop = True
        Mild.Text = "Mild"
        Mild.UseVisualStyleBackColor = True
        ' 
        ' Plain
        ' 
        Plain.AutoSize = True
        Plain.Font = New Font("Unispace", 15.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Plain.Location = New Point(360, 137)
        Plain.Name = "Plain"
        Plain.Size = New Size(142, 43)
        Plain.TabIndex = 16
        Plain.TabStop = True
        Plain.Text = "Plain"
        Plain.UseVisualStyleBackColor = True
        ' 
        ' Flavor
        ' 
        Flavor.AutoSize = True
        Flavor.Font = New Font("Unispace", 22.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Flavor.Location = New Point(245, 43)
        Flavor.Name = "Flavor"
        Flavor.Size = New Size(806, 53)
        Flavor.TabIndex = 8
        Flavor.Text = "Which Flavors would you like?"
        ' 
        ' GroupFive
        ' 
        GroupFive.Controls.Add(IgnoreFry)
        GroupFive.Controls.Add(LargeFry)
        GroupFive.Controls.Add(RegFry)
        GroupFive.Controls.Add(NoFry)
        GroupFive.Controls.Add(FryTime)
        GroupFive.Location = New Point(7, 191)
        GroupFive.Name = "GroupFive"
        GroupFive.Size = New Size(1240, 457)
        GroupFive.TabIndex = 17
        GroupFive.TabStop = False
        ' 
        ' IgnoreFry
        ' 
        IgnoreFry.AutoSize = True
        IgnoreFry.Font = New Font("Unispace", 15.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        IgnoreFry.Location = New Point(99, 69)
        IgnoreFry.Name = "IgnoreFry"
        IgnoreFry.Size = New Size(222, 43)
        IgnoreFry.TabIndex = 18
        IgnoreFry.TabStop = True
        IgnoreFry.Text = "IgnoreFry"
        IgnoreFry.UseVisualStyleBackColor = True
        ' 
        ' LargeFry
        ' 
        LargeFry.AutoSize = True
        LargeFry.Font = New Font("Unispace", 15.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LargeFry.Location = New Point(851, 133)
        LargeFry.Name = "LargeFry"
        LargeFry.Size = New Size(222, 43)
        LargeFry.TabIndex = 17
        LargeFry.TabStop = True
        LargeFry.Text = "Large Fry"
        LargeFry.UseVisualStyleBackColor = True
        ' 
        ' RegFry
        ' 
        RegFry.AutoSize = True
        RegFry.Font = New Font("Unispace", 15.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        RegFry.Location = New Point(457, 137)
        RegFry.Name = "RegFry"
        RegFry.Size = New Size(262, 43)
        RegFry.TabIndex = 17
        RegFry.TabStop = True
        RegFry.Text = "Regular Fry"
        RegFry.UseVisualStyleBackColor = True
        ' 
        ' NoFry
        ' 
        NoFry.AutoSize = True
        NoFry.Font = New Font("Unispace", 15.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        NoFry.Location = New Point(99, 137)
        NoFry.Name = "NoFry"
        NoFry.Size = New Size(222, 43)
        NoFry.TabIndex = 16
        NoFry.TabStop = True
        NoFry.Text = "Not Today"
        NoFry.UseVisualStyleBackColor = True
        ' 
        ' FryTime
        ' 
        FryTime.AutoSize = True
        FryTime.Font = New Font("Unispace", 22.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        FryTime.Location = New Point(502, 35)
        FryTime.Name = "FryTime"
        FryTime.Size = New Size(266, 53)
        FryTime.TabIndex = 8
        FryTime.Text = "Fry Time?"
        ' 
        ' GroupNine
        ' 
        GroupNine.Controls.Add(Receipt)
        GroupNine.Controls.Add(TotBox)
        GroupNine.Controls.Add(SubBox)
        GroupNine.Controls.Add(Clear)
        GroupNine.Controls.Add(Confirm)
        GroupNine.Controls.Add(Total)
        GroupNine.Controls.Add(SubTotal)
        GroupNine.Controls.Add(Order)
        GroupNine.Location = New Point(9, 165)
        GroupNine.Name = "GroupNine"
        GroupNine.Size = New Size(1240, 521)
        GroupNine.TabIndex = 21
        GroupNine.TabStop = False
        ' 
        ' Receipt
        ' 
        Receipt.Location = New Point(88, 82)
        Receipt.Name = "Receipt"
        Receipt.Size = New Size(736, 433)
        Receipt.TabIndex = 25
        Receipt.TabStop = False
        ' 
        ' TotBox
        ' 
        TotBox.Font = New Font("Unispace", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TotBox.Location = New Point(1069, 294)
        TotBox.Name = "TotBox"
        TotBox.Size = New Size(124, 42)
        TotBox.TabIndex = 24
        TotBox.TabStop = False
        TotBox.Text = "GroupBox1"
        ' 
        ' SubBox
        ' 
        SubBox.Font = New Font("Unispace", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SubBox.Location = New Point(1069, 248)
        SubBox.Name = "SubBox"
        SubBox.Size = New Size(123, 48)
        SubBox.TabIndex = 23
        SubBox.TabStop = False
        SubBox.Text = "GroupBox1"
        ' 
        ' Clear
        ' 
        Clear.Font = New Font("Unispace", 14.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Clear.Location = New Point(1049, 384)
        Clear.Name = "Clear"
        Clear.Size = New Size(163, 51)
        Clear.TabIndex = 22
        Clear.Text = "Clear "
        Clear.UseVisualStyleBackColor = True
        ' 
        ' Confirm
        ' 
        Confirm.Font = New Font("Unispace", 14.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Confirm.Location = New Point(857, 384)
        Confirm.Name = "Confirm"
        Confirm.Size = New Size(169, 51)
        Confirm.TabIndex = 11
        Confirm.Text = "Confirm"
        Confirm.UseVisualStyleBackColor = True
        ' 
        ' Total
        ' 
        Total.AutoSize = True
        Total.Font = New Font("Unispace", 15.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Total.Location = New Point(927, 301)
        Total.Name = "Total"
        Total.Size = New Size(157, 39)
        Total.TabIndex = 10
        Total.Text = "Total: "
        ' 
        ' SubTotal
        ' 
        SubTotal.AutoSize = True
        SubTotal.Font = New Font("Unispace", 15.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        SubTotal.Location = New Point(871, 262)
        SubTotal.Name = "SubTotal"
        SubTotal.Size = New Size(197, 39)
        SubTotal.TabIndex = 9
        SubTotal.Text = "SubTotal:"
        ' 
        ' Order
        ' 
        Order.AutoSize = True
        Order.Font = New Font("Unispace", 22.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Order.Location = New Point(420, 26)
        Order.Name = "Order"
        Order.Size = New Size(374, 53)
        Order.TabIndex = 8
        Order.Text = "Order Summary"
        ' 
        ' GroupSix
        ' 
        GroupSix.Controls.Add(IgnoreDrink)
        GroupSix.Controls.Add(LargeDrink)
        GroupSix.Controls.Add(RegularDrink)
        GroupSix.Controls.Add(NoDrink)
        GroupSix.Controls.Add(Thirsty)
        GroupSix.Location = New Point(9, 191)
        GroupSix.Name = "GroupSix"
        GroupSix.Size = New Size(1243, 432)
        GroupSix.TabIndex = 18
        GroupSix.TabStop = False
        ' 
        ' IgnoreDrink
        ' 
        IgnoreDrink.AutoSize = True
        IgnoreDrink.Location = New Point(99, 35)
        IgnoreDrink.Name = "IgnoreDrink"
        IgnoreDrink.Size = New Size(169, 27)
        IgnoreDrink.TabIndex = 19
        IgnoreDrink.TabStop = True
        IgnoreDrink.Text = "RadioButton1"
        IgnoreDrink.UseVisualStyleBackColor = True
        ' 
        ' LargeDrink
        ' 
        LargeDrink.AutoSize = True
        LargeDrink.Font = New Font("Unispace", 15.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        LargeDrink.Location = New Point(851, 133)
        LargeDrink.Name = "LargeDrink"
        LargeDrink.Size = New Size(262, 43)
        LargeDrink.TabIndex = 17
        LargeDrink.TabStop = True
        LargeDrink.Text = "Large Drink"
        LargeDrink.UseVisualStyleBackColor = True
        ' 
        ' RegularDrink
        ' 
        RegularDrink.AutoSize = True
        RegularDrink.Font = New Font("Unispace", 15.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        RegularDrink.Location = New Point(457, 137)
        RegularDrink.Name = "RegularDrink"
        RegularDrink.Size = New Size(302, 43)
        RegularDrink.TabIndex = 17
        RegularDrink.TabStop = True
        RegularDrink.Text = "Regular Drink"
        RegularDrink.UseVisualStyleBackColor = True
        ' 
        ' NoDrink
        ' 
        NoDrink.AutoSize = True
        NoDrink.Font = New Font("Unispace", 15.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        NoDrink.Location = New Point(99, 137)
        NoDrink.Name = "NoDrink"
        NoDrink.Size = New Size(222, 43)
        NoDrink.TabIndex = 16
        NoDrink.TabStop = True
        NoDrink.Text = "Not Today"
        NoDrink.UseVisualStyleBackColor = True
        ' 
        ' Thirsty
        ' 
        Thirsty.AutoSize = True
        Thirsty.Font = New Font("Unispace", 22.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Thirsty.Location = New Point(502, 35)
        Thirsty.Name = "Thirsty"
        Thirsty.Size = New Size(239, 53)
        Thirsty.TabIndex = 8
        Thirsty.Text = "Thirsty?"
        ' 
        ' GroupSeven
        ' 
        GroupSeven.Controls.Add(ComboBox1)
        GroupSeven.Controls.Add(Label3)
        GroupSeven.Controls.Add(BlueCheeseBox)
        GroupSeven.Controls.Add(Label2)
        GroupSeven.Controls.Add(Label1)
        GroupSeven.Controls.Add(RanchBox)
        GroupSeven.Controls.Add(Sauce)
        GroupSeven.Location = New Point(7, 191)
        GroupSeven.Name = "GroupSeven"
        GroupSeven.Size = New Size(1243, 439)
        GroupSeven.TabIndex = 19
        GroupSeven.TabStop = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Font = New Font("Unispace", 14.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        ComboBox1.Location = New Point(844, 182)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(161, 42)
        ComboBox1.TabIndex = 23
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Unispace", 22.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(771, 123)
        Label3.Name = "Label3"
        Label3.Size = New Size(374, 53)
        Label3.TabIndex = 22
        Label3.Text = "Honey Mustard"
        ' 
        ' BlueCheeseBox
        ' 
        BlueCheeseBox.DropDownStyle = ComboBoxStyle.DropDownList
        BlueCheeseBox.Font = New Font("Unispace", 14.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        BlueCheeseBox.FormattingEnabled = True
        BlueCheeseBox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        BlueCheeseBox.Location = New Point(444, 185)
        BlueCheeseBox.Name = "BlueCheeseBox"
        BlueCheeseBox.Size = New Size(161, 42)
        BlueCheeseBox.TabIndex = 21
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Unispace", 22.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(386, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(320, 53)
        Label2.TabIndex = 20
        Label2.Text = "Blue Cheese"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Unispace", 22.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(135, 133)
        Label1.Name = "Label1"
        Label1.Size = New Size(158, 53)
        Label1.TabIndex = 19
        Label1.Text = "Ranch"
        ' 
        ' RanchBox
        ' 
        RanchBox.DropDownStyle = ComboBoxStyle.DropDownList
        RanchBox.Font = New Font("Unispace", 14.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        RanchBox.FormattingEnabled = True
        RanchBox.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        RanchBox.Location = New Point(135, 186)
        RanchBox.Name = "RanchBox"
        RanchBox.Size = New Size(161, 42)
        RanchBox.TabIndex = 18
        ' 
        ' Sauce
        ' 
        Sauce.AutoSize = True
        Sauce.Font = New Font("Unispace", 22.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Sauce.Location = New Point(430, 35)
        Sauce.Name = "Sauce"
        Sauce.Size = New Size(185, 53)
        Sauce.TabIndex = 8
        Sauce.Text = "Sauce?"
        ' 
        ' GroupEight
        ' 
        GroupEight.Controls.Add(No)
        GroupEight.Controls.Add(More)
        GroupEight.Location = New Point(9, 191)
        GroupEight.Name = "GroupEight"
        GroupEight.Size = New Size(1243, 445)
        GroupEight.TabIndex = 20
        GroupEight.TabStop = False
        ' 
        ' No
        ' 
        No.Font = New Font("Unispace", 17.9999981F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        No.Location = New Point(424, 151)
        No.Name = "No"
        No.Size = New Size(347, 108)
        No.TabIndex = 10
        No.Text = "Go to cart"
        No.UseVisualStyleBackColor = True
        ' 
        ' More
        ' 
        More.AutoSize = True
        More.Font = New Font("Unispace", 22.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        More.Location = New Point(134, 54)
        More.Name = "More"
        More.Size = New Size(941, 53)
        More.TabIndex = 8
        More.Text = "Order added to cart, Let's see it."
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1252, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(217, 796)
        PictureBox1.TabIndex = 22
        PictureBox1.TabStop = False
        ' 
        ' ReceiptLBL
        ' 
        ReceiptLBL.AutoSize = True
        ReceiptLBL.Font = New Font("Verdana", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ReceiptLBL.Location = New Point(160, 683)
        ReceiptLBL.Name = "ReceiptLBL"
        ReceiptLBL.Size = New Size(829, 25)
        ReceiptLBL.TabIndex = 23
        ReceiptLBL.Text = "Receipt File can be found in File Explorer as JadensWingWorldreceipt.txt"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12.0F, 23.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1468, 795)
        Controls.Add(ReceiptLBL)
        Controls.Add(PictureBox1)
        Controls.Add(GroupSeven)
        Controls.Add(GroupNine)
        Controls.Add(GroupFive)
        Controls.Add(GroupSix)
        Controls.Add(GroupEight)
        Controls.Add(GroupFour)
        Controls.Add(GroupThree)
        Controls.Add(GroupTwo)
        Controls.Add(GroupOne)
        Controls.Add(NextBttn)
        Controls.Add(GoBack)
        Controls.Add(ExitBttn)
        Controls.Add(Background)
        Font = New Font("Showcard Gothic", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        Text = "Form1"
        Background.ResumeLayout(False)
        Background.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        GroupOne.ResumeLayout(False)
        GroupOne.PerformLayout()
        GroupTwo.ResumeLayout(False)
        GroupTwo.PerformLayout()
        GroupThree.ResumeLayout(False)
        GroupThree.PerformLayout()
        GroupFour.ResumeLayout(False)
        GroupFour.PerformLayout()
        GroupFive.ResumeLayout(False)
        GroupFive.PerformLayout()
        GroupNine.ResumeLayout(False)
        GroupNine.PerformLayout()
        GroupSix.ResumeLayout(False)
        GroupSix.PerformLayout()
        GroupSeven.ResumeLayout(False)
        GroupSeven.PerformLayout()
        GroupEight.ResumeLayout(False)
        GroupEight.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents Location As Label
    Friend WithEvents Start As Button
    Friend WithEvents Slogan As Label
    Friend WithEvents Background As GroupBox
    Friend WithEvents ExitBttn As Button
    Friend WithEvents GoBack As Button
    Friend WithEvents WingCount As Label
    Friend WithEvents TenWings As RadioButton
    Friend WithEvents FifteenWings As RadioButton
    Friend WithEvents TwentyWings As RadioButton
    Friend WithEvents Ignore As RadioButton
    Friend WithEvents NextBttn As Button
    Friend WithEvents GroupOne As GroupBox
    Friend WithEvents GroupTwo As GroupBox
    Friend WithEvents GroupThree As GroupBox
    Friend WithEvents Drums As RadioButton
    Friend WithEvents WingType As Label
    Friend WithEvents IDC As RadioButton
    Friend WithEvents Flats As RadioButton
    Friend WithEvents GroupFour As GroupBox
    Friend WithEvents Plain As RadioButton
    Friend WithEvents Flavor As Label
    Friend WithEvents Ouch As RadioButton
    Friend WithEvents Hot As RadioButton
    Friend WithEvents Medium As RadioButton
    Friend WithEvents Mild As RadioButton
    Friend WithEvents GarlicParm As RadioButton
    Friend WithEvents LemonPepper As RadioButton
    Friend WithEvents SpicyBBQ As RadioButton
    Friend WithEvents Teriyaki As RadioButton
    Friend WithEvents BBQ As RadioButton
    Friend WithEvents GroupFive As GroupBox
    Friend WithEvents LargeFry As RadioButton
    Friend WithEvents RegFry As RadioButton
    Friend WithEvents NoFry As RadioButton
    Friend WithEvents FryTime As Label
    Friend WithEvents SplitFlavor As CheckBox
    Friend WithEvents GroupSix As GroupBox
    Friend WithEvents LargeDrink As RadioButton
    Friend WithEvents RegularDrink As RadioButton
    Friend WithEvents NoDrink As RadioButton
    Friend WithEvents Thirsty As Label
    Friend WithEvents GroupSeven As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RanchBox As ComboBox
    Friend WithEvents Sauce As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BlueCheeseBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupEight As GroupBox
    Friend WithEvents No As Button
    Friend WithEvents More As Label
    Friend WithEvents GroupNine As GroupBox
    Friend WithEvents Confirm As Button
    Friend WithEvents Total As Label
    Friend WithEvents SubTotal As Label
    Friend WithEvents Order As Label
    Friend WithEvents Clear As Button
    Friend WithEvents TotBox As GroupBox
    Friend WithEvents SubBox As GroupBox
    Friend WithEvents IgnoreFlavor As RadioButton
    Friend WithEvents IgnoreDrink As RadioButton
    Friend WithEvents IgnoreFry As RadioButton
    Friend WithEvents Receipt As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ReceiptLBL As Label

End Class

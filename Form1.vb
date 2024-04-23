'Jaden Torres
'Capstone Project
'Professor: Bruce Montgomery
'My very own Wings order program
'Sources: (P1, A7)
'https://learn.microsoft.com/en-us/dotnet/visual-basic/developing-apps/programming/drives-directories-files/how-to-create-a-file 
Imports System.IO
Imports System.Text

Public Class Form1

    Dim PageCt As Integer = 1 'Page counter. Easier to navigate pages
    Dim WingCt As String 'wing count string
    Dim WingCtProc As Integer 'Accounts for proper button pressed for wing count
    Dim WingCtTen As Decimal = 10.99 '10 wings
    Dim WingCtFifteen As Decimal = 15.99 '15 wings
    Dim WingCtTwenty As Decimal = 20.99 '20 wings
    Dim WingTypeProc As Integer 'Accounts for proper button pressed for wing type
    Dim WingTypeCost As Decimal = 1.25 'additional cost for either all flats or all drums
    Dim Flavors = New String() {"- Plain", "- Mild", "- Medium", "- Hot", "- Ouch!", "- BBQ", "- Spicy BBQ", "- Teriyaki", "- Lemon Pepper", "- Garlic Parmensean"} 'list for all flavors
    Dim FlavorZ As String 'final form of flavor to send to receipt
    Dim FlavorZToo As String 'final form of second flavor to send to receipt
    Dim FryZ As String 'final form of fry to send to receipt
    Dim DrinkZ As String 'final form of drink to send to receipt
    Dim WingCtZ As String 'final form of wing count to send to receipt
    Dim WingTypeZ As String 'final form of wing type to send to receipt
    Dim RanchZ As String 'final form of ranch count to send to receipt
    Dim BlueZ As String ' final form of blue cheese count to send to receipt
    Dim HoneyZ As String ' final form of honey mustard count to send to receipt
    Dim SauceZ As String ' final conjoined of all sauces together
    Dim FlavorProc As Integer ' Accounts for the proper button pressed for the flavor
    Dim FryProc As Integer ' Accounts for the proper button pressed for the Fry
    Dim NotFry As Boolean 'No fries
    Dim RegularFry As Decimal = 3.99 'regular fries
    Dim LrgFry As Decimal = 5.99 'large fries
    Dim DrinkProc As Integer 'Accounts for the proper button pressed for the drink
    Dim NotDrink As Boolean 'Not used
    Dim RegDrink As Decimal = 1.99 'regular drink
    Dim LrgDrink As Decimal = 2.99 'large drink
    Dim Sauces = New Integer() {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10} 'sauce list
    Dim SaucePRC As Decimal = 0.25 'extra sauce cost
    Dim SauceMULT As Integer ' used to multiple the extra sauces with the cost
    Dim RanchProc As Integer 'Accounts for the number of ranch needed
    Dim BlueProc As Integer 'Accounts for the number of Blue cheese needed
    Dim HoneyProc As Integer 'Accounts for the number of Honey Mustard needed
    Dim MealProc As Integer 'Not used
    Dim Meal As String 'Not used
    Dim PriceHold As Decimal 'Temporary price holder until a subtotal is formed
    Dim Tax As Decimal ' 0.07
    Dim SubAnswer As Decimal 'Subtotal minus the taxes
    Dim FinalAnswer As Decimal 'total including taxes
    Dim Items As String 'String Holding receipt
    Dim TooTool As Boolean = False 'Used to determine if the split flavor was pressed to be used in receipt
    Dim path As String = "JadensWingWorldreceipt.txt" 'path for receipt



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'loads formed
        Ignore.PerformClick()
        Ignore.Hide()
        GoBack.Hide()
        NextBttn.Hide()
        ReceiptLBL.Hide()
        PageOne()
    End Sub

    Private Sub PageOne() 'main menu
        GroupOne.Show()
        GroupTwo.Hide()
        GroupThree.Hide()
        GroupFour.Hide()
        GroupFive.Hide()
        GroupSix.Hide()
        GroupSeven.Hide()
        GroupEight.Hide()
        GroupNine.Hide()
        GoBack.Hide()
        NextBttn.Hide()
    End Sub

    Private Sub PageTwo() 'wing count
        Ignore.Show()
        Ignore.PerformClick()
        Ignore.Hide()
        GroupOne.Hide()
        GroupThree.Hide()
        GroupEight.Hide()
        GroupTwo.Show()
        GoBack.Show()
        NextBttn.Show()
    End Sub

    Private Sub PageThree() 'wing type
        Ignore.Show()
        Ignore.PerformClick()
        Ignore.Hide()
        GroupTwo.Hide()
        GroupFour.Hide()
        GroupThree.Show()
        GoBack.Show()
        NextBttn.Show()
    End Sub

    Private Sub PageFour() ' wing flavor
        Ignore.Show()
        Ignore.PerformClick()
        Ignore.Hide()
        IgnoreFlavor.Hide()
        GroupThree.Hide()
        GroupFive.Hide()
        GroupFour.Show()
        GoBack.Show()
        NextBttn.Show()
    End Sub

    Private Sub PageFive() 'fry
        Ignore.Show()
        Ignore.PerformClick()
        Ignore.Hide()
        IgnoreFry.PerformClick()
        IgnoreFry.Hide()
        GroupFour.Hide()
        GroupSix.Hide()
        GroupFive.Show()
        GoBack.Show()
        NextBttn.Show()
    End Sub

    Private Sub PageSix() 'drink
        Ignore.Show()
        Ignore.PerformClick()
        Ignore.Hide()
        IgnoreDrink.PerformClick()
        IgnoreDrink.Hide()
        GroupFive.Hide()
        GroupSeven.Hide()
        GroupSix.Show()
        GoBack.Show()
        NextBttn.Show()
    End Sub

    Private Sub PageSeven() 'sauce
        Ignore.Show()
        Ignore.PerformClick()
        Ignore.Hide()
        GroupSix.Hide()
        GroupEight.Hide()
        GroupSeven.Show()
        GoBack.Show()
        NextBttn.Show()
    End Sub

    Private Sub PageEight() 'order more?
        GroupSix.Hide()
        GroupSeven.Hide()
        GroupEight.Show()
        GoBack.Show()
        NextBttn.Hide()
    End Sub

    Private Sub PageNine() 'order summary
        GroupEight.Hide()
        GroupNine.Show()
        GoBack.Hide()
        NextBttn.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Title.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Start.Click
        PageTwo()
        PageCt = PageCt + 1
    End Sub

    Private Sub GoBack_Click(sender As Object, e As EventArgs) Handles GoBack.Click
        If PageCt = 2 Then
            PageCt = PageCt - 1
            PageOne()
        Else
            If PageCt = 3 Then
                PageCt = PageCt - 1
                PageTwo()
            Else
                If PageCt = 4 Then
                    PageCt = PageCt - 1
                    PageThree()
                Else
                    If PageCt = 5 Then
                        PageCt = PageCt - 1
                        PageFour()
                    Else
                        If PageCt = 6 Then
                            PageCt = PageCt - 1
                            PageFive()
                        Else
                            If PageCt = 7 Then
                                PageCt = PageCt - 1
                                PageSix()
                            Else
                                If PageCt = 8 Then
                                    PageCt = PageCt - 1
                                    PageSeven()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub NextBttn_Click(sender As Object, e As EventArgs) Handles NextBttn.Click
        If PageCt = 2 Then
            PageCt = PageCt + 1
            PageThree()
        Else
            If PageCt = 3 Then
                PageCt = PageCt + 1
                PageFour()
            Else
                If PageCt = 4 Then
                    PageCt = PageCt + 1
                    PageFive()
                Else
                    If PageCt = 5 Then
                        PageCt = PageCt + 1
                        PageSix()
                    Else
                        If PageCt = 6 Then
                            PageCt = PageCt + 1
                            PageSeven()
                        Else
                            If PageCt = 7 Then
                                PageCt = PageCt + 1
                                PageEight()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ExitBttn_Click(sender As Object, e As EventArgs) Handles ExitBttn.Click 'exits the program
        Close()
    End Sub

    Private Sub Ignore_CheckedChanged(sender As Object, e As EventArgs) Handles Ignore.CheckedChanged 'Main menu ignore

    End Sub

    Private Sub TenWings_CheckedChanged(sender As Object, e As EventArgs) Handles TenWings.CheckedChanged '10 wing button
        WingCtProc = 1
    End Sub

    Private Sub FifteenWings_CheckedChanged(sender As Object, e As EventArgs) Handles FifteenWings.CheckedChanged '15 wing button
        WingCtProc = 2
    End Sub

    Private Sub TwentyWings_CheckedChanged(sender As Object, e As EventArgs) Handles TwentyWings.CheckedChanged '20 wing button
        WingCtProc = 3
    End Sub

    Private Sub Drums_CheckedChanged(sender As Object, e As EventArgs) Handles Drums.CheckedChanged 'drums button
        WingTypeProc = 1

    End Sub

    Private Sub Flats_CheckedChanged(sender As Object, e As EventArgs) Handles Flats.CheckedChanged 'flats button
        WingTypeProc = 2
    End Sub

    Private Sub IDC_CheckedChanged(sender As Object, e As EventArgs) Handles IDC.CheckedChanged 'idc button
        WingTypeProc = 3
    End Sub

    Private Sub Plain_CheckedChanged(sender As Object, e As EventArgs) Handles Plain.CheckedChanged 'plain button
        FlavorProc = 0
    End Sub

    Private Sub Mild_CheckedChanged(sender As Object, e As EventArgs) Handles Mild.CheckedChanged 'mild button
        FlavorProc = 1
    End Sub

    Private Sub Medium_CheckedChanged(sender As Object, e As EventArgs) Handles Medium.CheckedChanged 'medium button
        FlavorProc = 2
    End Sub

    Private Sub Hot_CheckedChanged(sender As Object, e As EventArgs) Handles Hot.CheckedChanged 'hot button
        FlavorProc = 3
    End Sub

    Private Sub Ouch_CheckedChanged(sender As Object, e As EventArgs) Handles Ouch.CheckedChanged 'ouch button
        FlavorProc = 4
    End Sub

    Private Sub BBQ_CheckedChanged(sender As Object, e As EventArgs) Handles BBQ.CheckedChanged 'bbq button
        FlavorProc = 5
    End Sub

    Private Sub SpicyBBQ_CheckedChanged(sender As Object, e As EventArgs) Handles SpicyBBQ.CheckedChanged 'spicy bbq button
        FlavorProc = 6
    End Sub

    Private Sub Teriyaki_CheckedChanged(sender As Object, e As EventArgs) Handles Teriyaki.CheckedChanged 'teriyaki button
        FlavorProc = 7
    End Sub

    Private Sub LemonPepper_CheckedChanged(sender As Object, e As EventArgs) Handles LemonPepper.CheckedChanged 'lemon pepper button
        FlavorProc = 8
    End Sub

    Private Sub GarlicParm_CheckedChanged(sender As Object, e As EventArgs) Handles GarlicParm.CheckedChanged 'garlic parm button
        FlavorProc = 9
    End Sub

    Private Sub Sauce_Click(sender As Object, e As EventArgs) Handles Sauce.Click

    End Sub

    Private Sub No_Click(sender As Object, e As EventArgs) Handles No.Click ' cart button
        Compute()
        PageNine()
    End Sub
    Private Sub NoFry_CheckedChanged(sender As Object, e As EventArgs) Handles NoFry.CheckedChanged ' no fry button
        FryProc = 1
    End Sub

    Private Sub RegFry_CheckedChanged(sender As Object, e As EventArgs) Handles RegFry.CheckedChanged ' reg fry button
        FryProc = 2
    End Sub

    Private Sub LargeFry_CheckedChanged(sender As Object, e As EventArgs) Handles LargeFry.CheckedChanged 'large fry button
        FryProc = 3
    End Sub

    Private Sub RanchBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RanchBox.SelectedIndexChanged 'ranch combo box
        RanchProc = RanchBox.Text
    End Sub

    Private Sub BlueCheeseBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BlueCheeseBox.SelectedIndexChanged 'blue cheese combo box
        BlueProc = BlueCheeseBox.Text
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged 'honey mustard combo box
        HoneyProc = ComboBox1.Text
    End Sub

    Private Sub SplitFlavor_CheckedChanged(sender As Object, e As EventArgs) Handles SplitFlavor.CheckedChanged 'flavor splitter check box
        IgnoreFlavor.Show()
        IgnoreFlavor.PerformClick()
        IgnoreFlavor.Hide()
        TooTool = True
        FlavaTownToo()
    End Sub

    Private Sub WingTown() 'second screen wing count sub class
        WingCtZ = ""
        If WingCtProc = 1 Then
            WingCtZ = "- 10 Wings       $ 10.99"
        Else
            If WingCtProc = 2 Then
                WingCtZ = "- 15 Wings      $ 15.99"
            Else
                If WingCtProc = 3 Then
                    WingCtZ = "- 20 Wings     $ 20.99"

                End If
            End If
        End If
    End Sub

    Private Sub TypeTown() 'third screen wing type sub class
        WingTypeZ = ""
        If WingTypeProc = 1 Then
            WingTypeZ = "- All Drums       $ 1.25"
        Else
            If WingTypeProc = 2 Then
                WingTypeZ = "- All Flats      $ 1.25"
            Else
                If WingTypeProc = 3 Then
                    WingTypeZ = "- Wings and Flat"

                End If
            End If
        End If
    End Sub


    Private Sub FlavaTown() 'flavor town part two sub class
        FlavorZ = ""
        If FlavorProc = 0 Then 'each if statements accounts for each flavor'
            FlavorZ = Flavors(0) 'using the flavors array to call the individual bit'
        Else
            If FlavorProc = 1 Then 'each if statements accounts for each flavor'
                FlavorZ = Flavors(1)
            Else
                If FlavorProc = 2 Then 'each if statements accounts for each flavor'
                    FlavorZ = Flavors(2)
                Else
                    If FlavorProc = 3 Then 'each if statements accounts for each flavor'
                        FlavorZ = Flavors(3)
                    Else
                        If FlavorProc = 4 Then 'each if statements accounts for each flavor'
                            FlavorZ = Flavors(4)
                        Else
                            If FlavorProc = 5 Then 'each if statements accounts for each flavor'
                                FlavorZ = Flavors(5)
                            Else
                                If FlavorProc = 6 Then 'each if statements accounts for each flavor'
                                    FlavorZ = Flavors(6)
                                Else
                                    If FlavorProc = 7 Then 'each if statements accounts for each flavor'
                                        FlavorZ = Flavors(7)
                                    Else
                                        If FlavorProc = 8 Then 'each if statements accounts for each flavor'
                                            FlavorZ = Flavors(8)
                                        Else
                                            If FlavorProc = 9 Then 'each if statements accounts for each flavor'
                                                FlavorZ = Flavors(9)
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub FlavaTownToo() 'this only happens if split favor option box is checked
        FlavorZToo = ""
        If FlavorProc = 0 Then 'each if statements accounts for each flavor'
            FlavorZToo = Flavors(0) 'using the flavors array to call the individual bit'
        Else
            If FlavorProc = 1 Then 'each if statements accounts for each flavor'
                FlavorZToo = Flavors(1)
            Else
                If FlavorProc = 2 Then 'each if statements accounts for each flavor'
                    FlavorZToo = Flavors(2)
                Else
                    If FlavorProc = 3 Then 'each if statements accounts for each flavor'
                        FlavorZToo = Flavors(3)
                    Else
                        If FlavorProc = 4 Then 'each if statements accounts for each flavor'
                            FlavorZToo = Flavors(4)
                        Else
                            If FlavorProc = 5 Then 'each if statements accounts for each flavor'
                                FlavorZToo = Flavors(5)
                            Else
                                If FlavorProc = 6 Then 'each if statements accounts for each flavor'
                                    FlavorZToo = Flavors(6)
                                Else
                                    If FlavorProc = 7 Then 'each if statements accounts for each flavor'
                                        FlavorZToo = Flavors(7)
                                    Else
                                        If FlavorProc = 8 Then 'each if statements accounts for each flavor'
                                            FlavorZToo = Flavors(8)
                                        Else
                                            If FlavorProc = 9 Then 'each if statements accounts for each flavor'
                                                FlavorZToo = Flavors(9)
                                            Else
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub FryTown() 'fifth screen fry sub class
        FryZ = ""
        If FryProc = 0 Then
            FryZ = "- No Fries"
        Else
            If FryProc = 1 Then
                FryZ = "- Regular Fry      $ 3.99"
            Else
                If FryProc = 2 Then
                    FryZ = "- Large Fry     $ 5.99"

                End If
            End If
        End If
    End Sub

    Private Sub DrinkTown() 'sixth screen drink sub class
        DrinkZ = ""
        If DrinkProc = 1 Then
            DrinkZ = "- No Drink"
        Else
            If DrinkProc = 2 Then
                DrinkZ = "- Regular Drink      $ 1.99"
            Else
                If DrinkProc = 3 Then
                    DrinkZ = "- Large Drink     $ 2.99"

                End If
            End If
        End If
    End Sub

    Private Sub SauceTown() 'seven sauce sub class
        SauceZ = ""
        If RanchProc > 0 Then
            SauceZ = SauceZ + RanchZ
        Else
            If BlueProc > 0 Then
                SauceZ = SauceZ + BlueZ
            Else
                If HoneyZ > 0 Then
                    SauceZ = SauceZ + HoneyZ
                End If
            End If
        End If
    End Sub

    Private Sub Compute() 'compute when the cart page is triggered
        PriceHold = 0
        If WingCtProc = 1 Then
            PriceHold = PriceHold + WingCtTen
        Else
            If WingCtProc = 2 Then
                PriceHold = PriceHold + WingCtFifteen
            Else
                If WingCtProc = 3 Then
                    PriceHold = PriceHold + WingCtTwenty
                End If
            End If
        End If
        If WingTypeProc = 1 Then
            PriceHold = PriceHold + WingTypeCost
        Else
            If WingTypeProc = 2 Then
                PriceHold = PriceHold + WingTypeCost
            End If
        End If
        If FryProc = 2 Then
            PriceHold = PriceHold + RegularFry
        Else
            If FryProc = 3 Then
                PriceHold = PriceHold + LrgFry
            End If
        End If
        If DrinkProc = 2 Then
            PriceHold = PriceHold + RegDrink
        Else
            If DrinkProc = 3 Then
                PriceHold = PriceHold + LrgDrink
            End If
        End If
        RanchZ = ""
        BlueZ = ""
        HoneyZ = ""
        If RanchProc > 1 Then
            RanchZ = "- 1 Ranch"
            If RanchProc = 2 Then
                SauceMULT = 0
                SauceMULT = SaucePRC * 1
                PriceHold = PriceHold + SauceMULT
                RanchZ = "- 2 Ranch"
            Else
                If RanchProc = 3 Then
                    SauceMULT = 0
                    SauceMULT = SaucePRC * 2
                    PriceHold = PriceHold + SauceMULT
                    RanchZ = "- 3 Ranch"
                Else
                    If RanchProc = 4 Then
                        SauceMULT = 0
                        SauceMULT = SaucePRC * 3
                        PriceHold = PriceHold + SauceMULT
                        RanchZ = "- 4 Ranch"
                    Else
                        If RanchProc = 5 Then
                            SauceMULT = 0
                            SauceMULT = SaucePRC * 4
                            PriceHold = PriceHold + SauceMULT
                            RanchZ = "- 5 Ranch"
                        Else
                            If RanchProc = 6 Then
                                SauceMULT = 0
                                SauceMULT = SaucePRC * 5
                                PriceHold = PriceHold + SauceMULT
                                RanchZ = "- 6 Ranch"
                            Else
                                If RanchProc = 7 Then
                                    SauceMULT = 0
                                    SauceMULT = SaucePRC * 6
                                    PriceHold = PriceHold + SauceMULT
                                    RanchZ = "- 7 Ranch"
                                Else
                                    If RanchProc = 8 Then
                                        SauceMULT = 0
                                        SauceMULT = SaucePRC * 7
                                        PriceHold = PriceHold + SauceMULT
                                        RanchZ = "- 8 Ranch"
                                    Else
                                        If RanchProc = 9 Then
                                            SauceMULT = 0
                                            SauceMULT = SaucePRC * 8
                                            PriceHold = PriceHold + SauceMULT
                                            RanchZ = "- 9 Ranch"
                                        Else
                                            If RanchProc = 10 Then
                                                SauceMULT = 0
                                                SauceMULT = SaucePRC * 9
                                                PriceHold = PriceHold + SauceMULT
                                                RanchZ = "- 10 Ranch"
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If BlueProc > 1 Then
            BlueZ = "- 1 Blue Cheese"
            If BlueProc = 2 Then
                SauceMULT = 0
                SauceMULT = SaucePRC * 1
                PriceHold = PriceHold + SauceMULT
                BlueZ = "- 2 Blue Cheese"
            Else
                If BlueProc = 3 Then
                    SauceMULT = 0
                    SauceMULT = SaucePRC * 2
                    PriceHold = PriceHold + SauceMULT
                    BlueZ = "- 3 Blue Cheese"
                Else
                    If BlueProc = 4 Then
                        SauceMULT = 0
                        SauceMULT = SaucePRC * 3
                        PriceHold = PriceHold + SauceMULT
                        BlueZ = "- 4 Blue Cheese"
                    Else
                        If BlueProc = 5 Then
                            SauceMULT = 0
                            SauceMULT = SaucePRC * 4
                            PriceHold = PriceHold + SauceMULT
                            BlueZ = "- 5 Blue Cheese"
                        Else
                            If BlueProc = 6 Then
                                SauceMULT = 0
                                SauceMULT = SaucePRC * 5
                                PriceHold = PriceHold + SauceMULT
                                BlueZ = "- 6 Blue Cheese"
                            Else
                                If BlueProc = 7 Then
                                    SauceMULT = 0
                                    SauceMULT = SaucePRC * 6
                                    PriceHold = PriceHold + SauceMULT
                                    BlueZ = "- 7 Blue Cheese"
                                Else
                                    If BlueProc = 8 Then
                                        SauceMULT = 0
                                        SauceMULT = SaucePRC * 7
                                        PriceHold = PriceHold + SauceMULT
                                        BlueZ = "- 8 Blue Cheese"
                                    Else
                                        If BlueProc = 9 Then
                                            SauceMULT = 0
                                            SauceMULT = SaucePRC * 8
                                            PriceHold = PriceHold + SauceMULT
                                            BlueZ = "- 9 Blue Cheese"
                                        Else
                                            If BlueProc = 10 Then
                                                SauceMULT = 0
                                                SauceMULT = SaucePRC * 9
                                                PriceHold = PriceHold + SauceMULT
                                                BlueZ = "- 10 Blue Cheese"
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        If HoneyProc > 1 Then
            HoneyZ = "- 1 Honey Mustard"
            If HoneyProc = 2 Then
                SauceMULT = 0
                SauceMULT = SaucePRC * 1
                PriceHold = PriceHold + SauceMULT
                HoneyZ = "- 2 Honey Mustard"
            Else
                If HoneyProc = 3 Then
                    SauceMULT = 0
                    SauceMULT = SaucePRC * 2
                    PriceHold = PriceHold + SauceMULT
                    HoneyZ = "- 3 Honey Mustard"
                Else
                    If HoneyProc = 4 Then
                        SauceMULT = 0
                        SauceMULT = SaucePRC * 3
                        PriceHold = PriceHold + SauceMULT
                        HoneyZ = "- 4 Honey Mustard"
                    Else
                        If HoneyProc = 5 Then
                            SauceMULT = 0
                            SauceMULT = SaucePRC * 4
                            PriceHold = PriceHold + SauceMULT
                            HoneyZ = "- 5 Honey Mustard"
                        Else
                            If HoneyProc = 6 Then
                                SauceMULT = 0
                                SauceMULT = SaucePRC * 5
                                PriceHold = PriceHold + SauceMULT
                                HoneyZ = "- 6 Honey Mustard"
                            Else
                                If HoneyProc = 7 Then
                                    SauceMULT = 0
                                    SauceMULT = SaucePRC * 6
                                    PriceHold = PriceHold + SauceMULT
                                    HoneyZ = "- 7 Honey Mustard"
                                Else
                                    If HoneyProc = 8 Then
                                        SauceMULT = 0
                                        SauceMULT = SaucePRC * 7
                                        PriceHold = PriceHold + SauceMULT
                                        HoneyZ = "- 8 Honey Mustard"
                                    Else
                                        If HoneyProc = 9 Then
                                            SauceMULT = 0
                                            SauceMULT = SaucePRC * 8
                                            PriceHold = PriceHold + SauceMULT
                                            HoneyZ = "- 9 Honey Mustard"
                                        Else
                                            If HoneyProc = 10 Then
                                                SauceMULT = 0
                                                SauceMULT = SaucePRC * 9
                                                PriceHold = PriceHold + SauceMULT
                                                HoneyZ = "- 10 Honey Mustard"
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        SubAnswer = SubAnswer + PriceHold
        StatOutput()
    End Sub

    Private Sub StatOutput() 'formats the cart window into a receipt

        Tax = SubAnswer * 0.07
        FinalAnswer = Math.Round(SubAnswer + Tax, 2)
        ReceiptSetup()
        If TooTool = False Then
            FlavorZToo = "   "
        End If
        SubBox.Text = "$" + SubAnswer.ToString()
        TotBox.Text = "$" + FinalAnswer.ToString()
        Items = "
***********************************
        Jaden's Wing World    
           April 2024      
************************************
" + WingCtZ.ToString() + " 
   " + WingTypeZ.ToString + "       
  " + FlavorZ.ToString() + "
  " + FlavorZToo.ToString() + "            
" + FryZ.ToString() + "
" + DrinkZ.ToString() + "
" + RanchZ.ToString() + "
" + BlueZ.ToString() + "
" + HoneyZ.ToString() + "
    SubTotal: $" + SubAnswer.ToString + "
    Total: $" + FinalAnswer.ToString + "

THANK YOU 
THANK YOU
THANK YOU"
        Receipt.Text = "
***********************************
        Jaden's Wing World    
           April 2024      
************************************
" + WingCtZ.ToString() + " 
   " + WingTypeZ.ToString + "       
  " + FlavorZ.ToString() + "
  " + FlavorZToo.ToString() + "            
" + FryZ.ToString() + "
" + DrinkZ.ToString() + "
" + RanchZ.ToString() + "
" + BlueZ.ToString() + "
" + HoneyZ.ToString() + "

THANK YOU 
THANK YOU
THANK YOU"
        Dim fs As FileStream = File.Create(path) 'file create and path found in your repo
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(Items) 'Gathering information for file
        fs.Write(info, 0, info.Length) 'Writing information into file
        fs.Close() 'Closing file
        ReceiptLBL.Show()
    End Sub

    Private Sub ReceiptSetup()
        WingTown()
        TypeTown()
        FlavaTown()
        FryTown()
        DrinkTown()
    End Sub

    Private Sub Confirm_Click(sender As Object, e As EventArgs) Handles Confirm.Click ' Confirmation click button
        MsgBox("Order has been confirmed! We will see you here!")
        ResetE()
        PageCt = 1
        PageOne()
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click 'Clear button 
        Dim Msg, Style, Title, Response
        Msg = "Are you sure you want to clear your order?"
        Style = vbYesNo
        Title = "Clear Warning"
        Response = MsgBox(Msg, Style, Title)
        If Response = vbYes Then
            MsgBox("Your cart has been cleared!")
            ResetE()
            PageCt = 1
            PageOne()
        Else
        End If
    End Sub

    Private Sub ResetE() 'resets everything
        GroupOne.ResetText()
        GroupTwo.ResetText()
        GroupThree.ResetText()
        GroupFour.ResetText()
        GroupFive.ResetText()
        GroupSix.ResetText()
        GroupSeven.ResetText()
        Receipt.ResetText()
        ReceiptLBL.Hide()
        SubAnswer = 0
        FinalAnswer = 0
    End Sub

    Private Sub NoDrink_CheckedChanged(sender As Object, e As EventArgs) Handles NoDrink.CheckedChanged 'no drink button
        DrinkProc = 1
    End Sub

    Private Sub RegularDrink_CheckedChanged(sender As Object, e As EventArgs) Handles RegularDrink.CheckedChanged 'reg drink button
        DrinkProc = 2
    End Sub

    Private Sub LargeDrink_CheckedChanged(sender As Object, e As EventArgs) Handles LargeDrink.CheckedChanged 'large drink button
        DrinkProc = 3
    End Sub

    Private Sub SubBox_Enter(sender As Object, e As EventArgs) Handles SubBox.Enter 'Sub total box

    End Sub

    Private Sub TotBox_Enter(sender As Object, e As EventArgs) Handles TotBox.Enter 'total box

    End Sub

    Private Sub Receipt_Enter(sender As Object, e As EventArgs) Handles Receipt.Enter

    End Sub
End Class

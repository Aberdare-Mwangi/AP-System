Imports System.Data.OleDb
Imports System.IO

Public Class Menu

    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=C:\Users\opiyo\Music\HRS.accdb;"
    Dim connection As OleDbConnection = New OleDbConnection(connectionString)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Appetizers_Click(Nothing, EventArgs.Empty)
    End Sub

    Private cartForm As Cart
    Public Sub New(cartForm As Cart)
        InitializeComponent()
        Me.cartForm = cartForm
    End Sub

    Private Function ResizeImage(image As Image, targetWidth As Integer, targetHeight As Integer) As Image
        Dim resizedImage As New Bitmap(targetWidth, targetHeight)
        Using g As Graphics = Graphics.FromImage(resizedImage)
            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            g.DrawImage(image, 0, 0, targetWidth, targetHeight)
        End Using
        Return resizedImage
    End Function

    Private Sub SetImageInPictureBox(imagePath As String, pictureBox As PictureBox)
        Dim originalImage As Image = Image.FromFile(imagePath)
        Dim targetWidth As Integer = pictureBox.Width
        Dim targetHeight As Integer = pictureBox.Height
        Dim resizedImage As Image = ResizeImage(originalImage, targetWidth, targetHeight)
        pictureBox.Image = resizedImage
    End Sub





    Private Sub Appetizers_Click(sender As Object, e As EventArgs) Handles Appetizers.Click
        Dim imagePath As String
        imagePath = Path.Combine(Application.StartupPath, "Images\Appetizers\")
        SetImageInPictureBox(Path.Combine(imagePath, "Image1.jpeg"), PictureBox1)
        SetImageInPictureBox(Path.Combine(imagePath, "Image2.jpeg"), PictureBox2)
        SetImageInPictureBox(Path.Combine(imagePath, "Image3.jpeg"), PictureBox3)
        SetImageInPictureBox(Path.Combine(imagePath, "Image4.jpeg"), PictureBox4)
        SetImageInPictureBox(Path.Combine(imagePath, "Image5.jpeg"), PictureBox5)
        SetImageInPictureBox(Path.Combine(imagePath, "Image6.jpeg"), PictureBox6)
        SetImageInPictureBox(Path.Combine(imagePath, "Image7.jpeg"), PictureBox7)
        SetImageInPictureBox(Path.Combine(imagePath, "Image8.jpeg"), PictureBox8)
        SetImageInPictureBox(Path.Combine(imagePath, "Image9.jpeg"), PictureBox9)
        SetImageInPictureBox(Path.Combine(imagePath, "Image10.jpeg"), PictureBox10)

    End Sub

    Private Sub SoupsAndSalads_Click(sender As Object, e As EventArgs) Handles SoupsAndSalads.Click
        Dim imagePath As String
        imagePath = Path.Combine(Application.StartupPath, "Images\Soups\")
        SetImageInPictureBox(Path.Combine(imagePath, "Image1.jpeg"), PictureBox1)
        SetImageInPictureBox(Path.Combine(imagePath, "Image2.jpeg"), PictureBox2)
        SetImageInPictureBox(Path.Combine(imagePath, "Image3.jpeg"), PictureBox3)
        SetImageInPictureBox(Path.Combine(imagePath, "Image4.jpeg"), PictureBox4)
        SetImageInPictureBox(Path.Combine(imagePath, "Image5.jpeg"), PictureBox5)
        SetImageInPictureBox(Path.Combine(imagePath, "Image6.jpeg"), PictureBox6)
        SetImageInPictureBox(Path.Combine(imagePath, "Image7.jpeg"), PictureBox7)
        SetImageInPictureBox(Path.Combine(imagePath, "Image8.jpeg"), PictureBox8)
        SetImageInPictureBox(Path.Combine(imagePath, "Image9.jpeg"), PictureBox9)
        SetImageInPictureBox(Path.Combine(imagePath, "Image10.jpeg"), PictureBox10)
    End Sub

    Private Sub MainCourses_Click(sender As Object, e As EventArgs) Handles MainCourses.Click
        Dim imagePath As String
        imagePath = Path.Combine(Application.StartupPath, "Images\Main Course\")
        SetImageInPictureBox(Path.Combine(imagePath, "Image1.jpeg"), PictureBox1)
        SetImageInPictureBox(Path.Combine(imagePath, "Image2.jpeg"), PictureBox2)
        SetImageInPictureBox(Path.Combine(imagePath, "Image3.jpeg"), PictureBox3)
        SetImageInPictureBox(Path.Combine(imagePath, "Image4.jpeg"), PictureBox4)
        SetImageInPictureBox(Path.Combine(imagePath, "Image5.jpeg"), PictureBox5)
        SetImageInPictureBox(Path.Combine(imagePath, "Image6.jpeg"), PictureBox6)
        SetImageInPictureBox(Path.Combine(imagePath, "Image7.jpeg"), PictureBox7)
        SetImageInPictureBox(Path.Combine(imagePath, "Image8.jpeg"), PictureBox8)
        SetImageInPictureBox(Path.Combine(imagePath, "Image9.jpeg"), PictureBox9)
        SetImageInPictureBox(Path.Combine(imagePath, "Image10.jpeg"), PictureBox10)
    End Sub

    Private Sub Desserts_Click(sender As Object, e As EventArgs) Handles Desserts.Click
        Dim imagePath As String
        imagePath = Path.Combine(Application.StartupPath, "Images\Desserts\")
        SetImageInPictureBox(Path.Combine(imagePath, "Image1.jpeg"), PictureBox1)
        SetImageInPictureBox(Path.Combine(imagePath, "Image2.jpeg"), PictureBox2)
        SetImageInPictureBox(Path.Combine(imagePath, "Image3.jpeg"), PictureBox3)
        SetImageInPictureBox(Path.Combine(imagePath, "Image4.jpeg"), PictureBox4)
        SetImageInPictureBox(Path.Combine(imagePath, "Image5.jpeg"), PictureBox5)
        SetImageInPictureBox(Path.Combine(imagePath, "Image6.jpeg"), PictureBox6)
        SetImageInPictureBox(Path.Combine(imagePath, "Image7.jpeg"), PictureBox7)
        SetImageInPictureBox(Path.Combine(imagePath, "Image8.jpeg"), PictureBox8)
        SetImageInPictureBox(Path.Combine(imagePath, "Image9.jpeg"), PictureBox9)
        SetImageInPictureBox(Path.Combine(imagePath, "Image10.jpeg"), PictureBox10)
    End Sub

    Private Sub NonAlcoholic_Click(sender As Object, e As EventArgs) Handles NonAlcoholic.Click
        Dim imagePath As String
        imagePath = Path.Combine(Application.StartupPath, "Images\Non-Alcohol\")
        SetImageInPictureBox(Path.Combine(imagePath, "Image1.jpeg"), PictureBox1)
        SetImageInPictureBox(Path.Combine(imagePath, "Image2.jpeg"), PictureBox2)
        SetImageInPictureBox(Path.Combine(imagePath, "Image3.jpeg"), PictureBox3)
        SetImageInPictureBox(Path.Combine(imagePath, "Image4.jpeg"), PictureBox4)
        SetImageInPictureBox(Path.Combine(imagePath, "Image5.jpeg"), PictureBox5)
        SetImageInPictureBox(Path.Combine(imagePath, "Image6.jpeg"), PictureBox6)
        SetImageInPictureBox(Path.Combine(imagePath, "Image7.jpeg"), PictureBox7)
        SetImageInPictureBox(Path.Combine(imagePath, "Image8.jpeg"), PictureBox8)
        SetImageInPictureBox(Path.Combine(imagePath, "Image9.jpeg"), PictureBox9)
        SetImageInPictureBox(Path.Combine(imagePath, "Image10.jpeg"), PictureBox10)
    End Sub

    Private Sub Alcoholic_Click(sender As Object, e As EventArgs) Handles Alcoholic.Click
        Dim imagePath As String
        imagePath = Path.Combine(Application.StartupPath, "Images\Alcohol\")
        SetImageInPictureBox(Path.Combine(imagePath, "Image1.jpeg"), PictureBox1)
        SetImageInPictureBox(Path.Combine(imagePath, "Image2.jpeg"), PictureBox2)
        SetImageInPictureBox(Path.Combine(imagePath, "Image3.jpeg"), PictureBox3)
        SetImageInPictureBox(Path.Combine(imagePath, "Image4.jpeg"), PictureBox4)
        SetImageInPictureBox(Path.Combine(imagePath, "Image5.jpeg"), PictureBox5)
        SetImageInPictureBox(Path.Combine(imagePath, "Image6.jpeg"), PictureBox6)
        SetImageInPictureBox(Path.Combine(imagePath, "Image7.jpeg"), PictureBox7)
        SetImageInPictureBox(Path.Combine(imagePath, "Image8.jpeg"), PictureBox8)
        SetImageInPictureBox(Path.Combine(imagePath, "Image9.jpeg"), PictureBox9)
        SetImageInPictureBox(Path.Combine(imagePath, "Image10.jpeg"), PictureBox10)
    End Sub
    Private Sub ViewCart_Click(sender As Object, e As EventArgs) Handles ViewCart.Click
        Cart.Show()
    End Sub

    Private Sub AddToCartButton(sender As Object, e As EventArgs) Handles AddToCartButton1.Click, AddToCartButton2.Click, AddToCartButton3.Click, AddToCartButton4.Click, AddToCartButton5.Click, AddToCartButton6.Click, AddToCartButton7.Click, AddToCartButton8.Click, AddToCartButton9.Click, AddToCartButton10.Click
        Dim button As Button = DirectCast(sender, Button)
        Dim itemName As String = button.Text ' Assuming the button text is the item name
        ' Add the item to the cart
        cartForm.AddItemToCart(itemName)
    End Sub





End Class



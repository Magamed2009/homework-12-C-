class PhotoBook
{
    int cnt = 0;
    private int  numPage;
    public int GetNumberPages()
    {
        return cnt;
    }
    public PhotoBook ()
    {
        cnt = 16;
    }
    public PhotoBook (int a)
    {
        cnt=a;
    }
}

class BigPhotoBook : PhotoBook
{
    int cnt = 0;
    public BigPhotoBook()
    {
        cnt = 64;
    }
}

class PhotoBookTest : PhotoBook
{

}
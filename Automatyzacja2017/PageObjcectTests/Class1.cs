using System;
using Xunit;

namespace PageObjcectTests
{
    public class AddingBlogCommentsTests: IDisposable
    {
        [Fact]
        public void CanAddCommentToTheBlogNet()
        {
            MainPage.GoTo();
            MainPage.OpenFirstNote();
            NotePage.AddComment(new Comment
            {
                Text = "lorem ipsum dolor sit",
                Mail = "test@test.com",
                User = "białko"
            });
            
            //dodaj komentarz
            //sprawdz komentarz sie dodal 

        }
        public void Dispose()
        {
            Browser.Close();
        }
    }
}

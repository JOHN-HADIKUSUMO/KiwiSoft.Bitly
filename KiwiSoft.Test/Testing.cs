using System.Threading.Tasks;
using NUnit.Framework;
using KiwiSoft.Bitly;
using KiwiSoft.Bitly.Models;

namespace KiwiSoft.Test
{
    public class Testing
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Shortener shortener = new Shortener();
            ReturnURL result = shortener.Create("https://edi.wang/post/2019/4/24/how-to-pack-a-net-core-class-library-and-upload-to-nuget");
            Assert.IsTrue(result.Status);
            Assert.IsFalse(string.IsNullOrEmpty(result.Url));
        }


        [Test]
        public async Task Test2()
        {
            Shortener shortener = new Shortener();
            ReturnURL result = await shortener.CreateAsync("https://edi.wang/post/2019/4/24/how-to-pack-a-net-core-class-library-and-upload-to-nuget");
            Assert.IsTrue(result.Status);
            Assert.IsFalse(string.IsNullOrEmpty(result.Url));
        }
    }
}
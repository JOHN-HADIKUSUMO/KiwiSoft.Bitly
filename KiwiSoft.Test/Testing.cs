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

        [Test]
        public async Task Test3()
        {
            JsonConfiguration configuration = new Configuration();
            configuration.GroupGuid = "BlcgnMiKaen";
            configuration.Token = "663e96dfffd3d5d744dca9172719b01aed23eb09";

            Shortener shortener = new Shortener(configuration);
            ReturnURL result = await shortener.CreateAsync("https://edi.wang/post/2019/4/24/how-to-pack-a-net-core-class-library-and-upload-to-nuget");
            Assert.IsTrue(result.Status);
            Assert.IsFalse(string.IsNullOrEmpty(result.Url));
        }
    }
}
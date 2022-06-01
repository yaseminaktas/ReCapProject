using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Helpers.GuidHelper;

namespace Core.Utilities.Helpers.FileHelper
{
    public class FileManager : IFileHelper
    {
        public void Delete(string filePath)   //string filepath: carImageMangerdan gelen dosyanın kaydedildiği adres
        {
            if (File.Exists(filePath))  //parametreden gelen adreste öyle bir dosya var mı diye kontrol et
            {
                File.Delete(filePath);
            }
        }

        public string Update(IFormFile file, string filePath, string root)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);   //eğer dosya var ise siliniyor
            }
            return Upload(file, root);   // Eski dosya silindikten sonra yerine geçecek yeni dosyaiçin alttaki *Upload* metoduna yeni dosya ve kayıt edileceği adres parametre olarak döndürülüyor.
        }

        public string Upload(IFormFile file, string root)
        {
            if (file.Length>0)   //file.Length=>Dosya uzunluğunu bayt olarak alır. burada Dosya gönderil mi gönderilmemiş diye test işlemi yapıldı
            {
                if (!Directory.Exists(root))   //Directory=>System.IO'nın bir class'ı. Bu Upload metodumun parametresi olan string root CarManager'dan gelmekte
                                               //CarImageManager içerisine girdiğinizde buraya parametre olarak *PathConstants.ImagesPath* böyle bir şey gönderilidğini görürsünüz. PathConstants clası içerisine girdiğinizde string bir ifadeyle bir dizin adresi var
                                               //O adres bizim Yükleyeceğimiz dosyaların kayıt edileceği adres burada *Check if a directory Exists* ifadesi şunu belirtiyor dosyanın kaydedileceği adres dizini var mı? varsa if yapısının kod bloğundan ayrılır eğer yoksa içinde ki kodda dosyaların kayıt edilecek dizini oluşturur
                {
                    Directory.CreateDirectory(root);
                }
                string extension = Path.GetExtension(file.FileName);   //Path.GetExtension(file.FileName)=>> Seçmiş olduğumuz dosyanın uzantısını elde ediyoruz.
                string guid = GuidHelper.GuidHelper.CreateGuid();                // Dosyanın oluşturduğum adını ve uzantısını yan yana getiriyorum.Mesela metin dosyası ise .txt gibi bu projede resim yükyeceğim için.jpg olacak uzantılar
                string filePath = guid + extension;

                using(FileStream fileStream= File.Create(root + filePath))   //Burada en başta FileStrem class'ının bir örneği oluşturdum sonrasında File.Create(root + newPath)=>Belirtilen yolda bir dosya                                                                  oluşturur veya üzerine yazar. (root + newPath)=>Oluşturulacak dosyanın yolu ve adı.
                {
                    file.CopyTo(fileStream);   //Kopyalanacak dosyanın kopyalanacağı akışı belirtti. yani yukarıda gelen IFromFile türündeki file dosyasınınnereye kopyalacağını söyledik.
                    fileStream.Flush();    //arabellekten siler.
                    return filePath;     //burada dosyamızın tam adını geri gönderiyoruz sebebide sql servere dosya eklenirken adı ile eklenmesi için.
                }
            }
            return null;
        }
    }
}

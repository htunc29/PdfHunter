# PDFHunter - Paralel PDF Dosyası Arama Aracı

**PDFHunter**, kullanıcıların seçtiği klasördeki PDF dosyalarında anahtar kelimeleri hızlı bir şekilde arayabileceği bir araçtır. Paralel arama teknolojisi sayesinde, çok sayıda dosya üzerinde aynı anda arama yaparak işlemleri hızlandırır.

## Özellikler

- **Paralel Arama**: Birden fazla PDF dosyasını aynı anda tarayarak arama işlemini hızlandırır.
- **Hızlı ve Kolay Kullanım**: Kullanıcı dostu arayüz ile kolayca dosya seçebilir ve kelime araması yapabilirsiniz.
- **Tüm PDF Dosyalarında Arama**: Seçtiğiniz klasördeki tüm PDF dosyalarında arama yapabilirsiniz.
- **İlerleme Durumu**: Arama sürecinde ilerleme çubuğu ve görev çubuğu ile süreci takip edebilirsiniz.

## Gereksinimler

- **Windows Forms** (Visual Studio’da Windows Forms uygulaması)
- **iText** (PDF dosyalarını okumak ve metin çıkartmak için)
- **.NET Framework 4.7.2** ve üzeri
- **Guna UI** 

## Kurulum

1. Bu repository’i klonlayın veya kaynak kodunu indirin.
2. Projeyi Visual Studio’da açın.
3. Gerekli NuGet paketlerini yükleyin:
   - **iText**:
     ```bash
     Install-Package itext
     ```
4. Projeyi çalıştırın ve PDF dosyalarını taramaya başlayın!

## Kullanım

1. **Klasör Seçin**: PDF dosyalarını içeren klasörü seçin.
2. **Anahtar Kelime Girin**: Aramak istediğiniz kelimeyi yazın.
3. **Aramaya Başlayın**: Arama işlemini başlatın ve sonuçları anında görün.

### Örnek Adımlar:

- Uygulama açıldığında, klasör seçme butonuna tıklayarak PDF dosyalarının bulunduğu klasörü seçin.
- Aranacak kelimeyi yazın ve arama butonuna tıklayın.
- Arama işlemi sırasında ilerleme durumu görünür olacaktır.
- Sonuçlar, aradığınız kelimeyi içeren PDF dosyalarıyla birlikte listelenir.


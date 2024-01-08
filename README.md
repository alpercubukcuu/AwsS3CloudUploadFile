AWS S3 File Upload with .NET
Bu proje, .NET Core kullanarak AWS S3 bucket'ına dosya yüklemek için basit bir uygulamadır. AWS SDK for .NET ile birlikte, AWS Identity and Access Management (IAM) üzerinden oluşturulan kimlik bilgileri kullanılarak Amazon S3 bucket'ına dosya yüklemektedir.

Özellikler
AWS SDK for .NET kullanımı
IAM üzerinden oluşturulan kullanıcı kimlik bilgilerini kullanarak S3 bucket'ına dosya yükleme
AWS Credentials dosyasından otomatik olarak kimlik bilgilerini okuma
Gereksinimler
Bu projeyi çalıştırmak için aşağıdakilere ihtiyacınız vardır:

.NET Core 3.1 veya üzeri
AWS hesabı ve bir S3 bucket
IAM kullanıcısı ve bu kullanıcıya atanan AmazonS3FullAccess izni
AWS CLI ya da AWS SDK kullanarak oluşturulmuş credentials dosyası

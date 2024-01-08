using System;
using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Transfer;


namespace AwsCloud
{
    class Program
    {
        static async Task Main(string[] args)
        {

            // Get an AmazonS3Client object from the GetS3Client method.
            var s3Client = await GetS3Client();

            // File upload using the TransferUtility class
            var fileTransferUtility = new TransferUtility(s3Client);

            try
            {
                // Specify the file path and bucket name to upload
                await fileTransferUtility.UploadAsync("C:\\Users\\ALPER\\Desktop\\AWSFile.txt", "ac-upload-bucket");
                Console.WriteLine("File uploaded successfully.");
            }
            catch (AmazonS3Exception e)
            {
                Console.WriteLine("Error Message : " + e.Message);
            }

        }



        private static async Task<AmazonS3Client> GetS3Client(string profileName = null) 
        {
            if (string.IsNullOrEmpty(profileName))
            {
                // AWS credentials are automatically read from the credentials file
                return new AmazonS3Client(RegionEndpoint.APSoutheast2);
            }
            else
            {
                // Obtain AWS credentials using a specific profile
                var credentials = new StoredProfileAWSCredentials(profileName);
                return new AmazonS3Client(credentials, RegionEndpoint.APSoutheast2);
            }
        }
    }
}
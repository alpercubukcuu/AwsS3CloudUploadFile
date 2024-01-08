# AWS S3 File Upload with .NET

This project demonstrates a simple application using .NET Core to upload files to an AWS S3 bucket. It utilizes AWS SDK for .NET along with credentials set up through AWS Identity and Access Management (IAM) to perform file uploads to an Amazon S3 bucket.

## Features

- Utilizing AWS SDK for .NET
- Uploading files to S3 bucket using credentials created via IAM
- Automatically reading AWS credentials from a credentials file

## Requirements

To run this project, you will need:

- .NET Core 3.1 or higher
- An AWS account and an S3 bucket
- An IAM user with `AmazonS3FullAccess` permission
- `credentials` file created using AWS CLI or AWS SDK
  
 ## Installation

1. Clone or download the project from GitHub:
   git clone [[Your Project's GitHub URL](https://github.com/alpercubukcuu/AwsS3CloudUploadFile)]
2. Open the project and restore any dependencies if necessary.
   ## Usage

1. Create your `credentials` file with your AWS credentials and place it in the `.aws` directory.
2. In the `GetS3Client` method, specify your IAM user’s `profileName`, or leave it empty to use the default credentials.
3. In the `Main` method, specify the path of the file you want to upload and the name of your target S3 bucket.
4. Run the application and verify that the file has been successfully uploaded to your S3 bucket.

## Contributing

Contributors are welcome to submit pull requests or open issues to contribute to the project's development.

## License

This project is licensed under the [MIT License](LICENSE).

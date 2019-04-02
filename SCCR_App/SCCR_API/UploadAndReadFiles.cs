using Amazon.S3;
using Amazon.S3.Transfer;
using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Amazon.EC2.Model;
using Amazon.Internal;
using Amazon.S3.Model;

namespace SCCR_App.Api
{
    public class UploadAndReadFiles
    {
        private const string bucketName = "sccrfeed";
        private static readonly S3Region bucketRegion = S3Region.US;
        private static IAmazonS3 S3Client;

        public static async Task UploadFileAsync(TransferUtilityUploadRequest uploadRequest)
        {
            try
            {
                var fileTransferUtility = new TransferUtility(S3Client);
                await fileTransferUtility.UploadAsync(uploadRequest);
            }
            catch (AmazonS3Exception e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static async Task GetFileAsync(GetObjectRequest request) //a request requires the keyname and bucket name
        {
            string responseBody = "";
            try
            {
                using (GetObjectResponse response = await S3Client.GetObjectAsync(request))
                using (Stream responseStream = response.ResponseStream)
                using (StreamReader reader = new StreamReader(responseStream))
                {
                    string title = response.Metadata["x-amz-meta-title"]; // Assume you have "title" as medata added to the object.
                    string contentType = response.Headers["Content-Type"];
                    Console.WriteLine("Object metadata, Title: {0}", title);
                    Console.WriteLine("Content type: {0}", contentType);

                    responseBody = reader.ReadToEnd(); // Now you process the response body.
                }
            }
            catch (AmazonS3Exception e)
            {
                Console.WriteLine("Error encountered ***. Message:'{0}' when writing an object", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unknown encountered on server. Message:'{0}' when writing an object", e.Message);
            }
        }
    }
}
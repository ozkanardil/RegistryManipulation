# Secure Registry Data Storage Solution (C#)
This repository contains a secure data storage solution for sensitive information using the Windows registry editor in a .NET Core 6.0 environment. The solution provides a method to encrypt and store data securely within the registry, restricting access to authorized personnel only.

## Features

**Data Encryption:** The solution employs strong encryption techniques to protect sensitive data stored in the Windows registry.

**Registry Access Management:** By encrypting and storing data within the registry, access to the data is restricted, ensuring that only authorized individuals can retrieve and decrypt the information.


**Separation of Concerns:** The solution is structured into multiple projects, including a class project for security-related functionality, a console application for writing data to the registry, and a WebAPI project for reading data from the registry.

**Flexible Configuration:** The solution offers customization options through constants and settings, allowing for easy adaptation to different registry paths and encryption keys.

## Usage

1. Clone or download the repository to your local machine.  
2. Open the solution in Visual Studio or your preferred IDE.  
3. Customize the necessary variables in the Constants folder to match your desired registry path and encryption key.  
4. Build and run the application.  
5. Use the provided console application to write encrypted data to the registry and the WebAPI project to retrieve and decrypt the stored information.

For detailed instructions and code samples, please refer to the repository's documentation and source code.

## Contributions

Contributions, bug reports, and feature requests are welcome! If you encounter any issues or have suggestions for improvement, please open an issue on the repository or submit a pull request.

## License

This project is licensed under the MIT License.

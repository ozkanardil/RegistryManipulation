// See https://aka.ms/new-console-template for more information
using Microsoft.Win32;
using RegistryApp.BLL.Constants;
using RegistryApp.BLL.Managers;
using RegistryApp.BLL.Security;

Console.WriteLine("Registry Management Program!");

// STEP-1: Input
Console.WriteLine("Enter the Value To Write in Regitry");
string clearText = Console.ReadLine();

// STEP-2: Encrypt the Clear Text
EncryptData encryptText = new EncryptData();
string encryptedText = encryptText.Encrypt(clearText);

// STEP-3: Writing to the registry
WriteManager writeManager = new WriteManager();
bool result = writeManager.CreateRegistryValue(RegistryConstants.RegistryVariable, encryptedText);
string resultText = result == true ? "Writing is done!" : "Error on writing";
Console.WriteLine(resultText);



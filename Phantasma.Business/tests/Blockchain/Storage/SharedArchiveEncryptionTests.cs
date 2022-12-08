using System;
using System.Text;
using Phantasma.Core.Cryptography;
using Phantasma.Core.Domain;

namespace Phantasma.Business.Tests.Blockchain.Storage;

using Xunit;

using Phantasma.Business.Blockchain.Storage;

public class SharedArchiveEncryptionTests
{
    [Fact]
    public void TestSharedArchive()
    {
        var user = PhantasmaKeys.Generate();
        var archive = new SharedArchiveEncryption();
        Assert.Equal(archive.Source, Address.Null);
        Assert.Equal(archive.Destination, Address.Null);
        Assert.Equal(archive.Mode, ArchiveEncryptionMode.Shared);

        var data = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Assert.Throws<ChainException>(() =>
        {
            var encrypted = archive.Encrypt(data, user);
            var decrypted = archive.Decrypt(encrypted, user);
            Assert.Equal(data, decrypted);
        });
        
    }
    
    [Fact]
    public void TestSharedArchiveName()
    {
        var user = PhantasmaKeys.Generate();
        var archive = new SharedArchiveEncryption();
        Assert.Equal(archive.Source, Address.Null);
        Assert.Equal(archive.Destination, Address.Null);
        Assert.Equal(archive.Mode, ArchiveEncryptionMode.Shared);

        var data = "MyNameIs";
        Assert.Throws<NotImplementedException>(() =>
        {
            var encrypted = archive.EncryptName(data, user);
            var decrypted = archive.DecryptName(encrypted, user);
            Assert.Equal(data, decrypted);
        });
        
    }
}

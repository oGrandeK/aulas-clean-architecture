namespace CleanArchMvc.Domain.Tests;

public class ProductUnitTest1
{
    [Fact]
    public void CreateProduct_WithValidParameters_ResultObjectValidState()
    {
        Action action = () => new Product(1, "Product Name", "Product Description", 9.99m, 99, "Product Image");

        action.Should().NotThrow<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
    }

    [Fact]
    public void CreateProduct_NegativeIdValue_DomainExceptionInvalidId()
    {
        Action action = () => new Product(-1, "Product Name", "Product Description", 9.99m, 99, "Product Image");

        action.Should().Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
    }

    [Fact]
    public void CreateProduct_ShortNameValue_DomainExceptionShortName()
    {
        Action action = () => new Product(1, "Pr", "Product Description", 9.99m, 99, "Product Image");

        action.Should().Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
    }

    [Fact]
    public void CreateProduct_LongImageName_DomainExceptionLongImageName()
    {
        Action action = () => new Product(1, "Product Name", "Product Description", 9.99m, 99, "tfmthwcljlomehjioconhlhxqzbtsqshhclvmbqswjuxrpomstmevslvhjzxrxoyugplubuaeylfuoeojsnqihwxrvkrlhwlxaynubwogvnqcczynxbndeltxvycwcjehugvzncbskrqjutdqsltpkgzvjdukdfoekuownomyljwprvtmyahsmvrztfcltbzqwooydxjtetykgqpsnswgnnapxkgchyvhufcvyllgeamvnmkxnuewkyedjiokgoljmxiqaexcadahsocjdmhvfisgqccuoafkjexxutacmpdphfxhmlbsqeskklsetlyimepkmiboxxodggttncsajhqhbhjruorayyetjeuymjvghmihixdoicayugpivqsgieoktepjxwhcxtsejyrnljwpjppbvxjshzgpfqjncdnoancusanwitzjzhjgdesswjyjfyksig");

        action.Should().Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
    }

    [Fact]
    public void CreateProduct_WithNullImageName_NoDomainException()
    {
        Action action = () => new Product(1, "Product Name", "Product Description", 9.99m, 99, null);

        action.Should().NotThrow<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
    }

    [Fact]
    public void CreateProduct_WithNullImageName_NoNullReferenceException()
    {
        Action action = () => new Product(1, "Product Name", "Product Description", 9.99m, 99, null);

        action.Should().NotThrow<NullReferenceException>();
    }

    [Fact]
    public void CreateProduct_WithEmptyImageName_NoDomainException()
    {
        Action action = () => new Product(1, "Product Name", "Product Description", 9.99m, 99, "");

        action.Should().NotThrow<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
    }

    [Fact]
    public void CreateProduct_InvalidPriceValue_DomainException()
    {
        Action action = () => new Product(1, "Product Name", "Product Description", -9.99m, 99, "Product Image");

        action.Should().Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
    }

    [Theory]
    [InlineData(-5)]
    public void CreateProduct_InvalidStockValue_ExceptionDomainNegativeValue(int value)
    {
        Action action = () => new Product(1, "Product Name", "Product Description", 9.99m, value, "Product Image");

        action.Should().Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
    }
}
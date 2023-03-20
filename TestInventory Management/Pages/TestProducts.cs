using Bunit;
using Microsoft.Extensions.DependencyInjection;
using Inventory_Management.Pages;
using Inventory_Management.InventoryApp;

namespace TestInventory_Management
{
	public class TestProducts
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbButtonModule),
				typeof(IgbRippleModule),
				typeof(IgbInputModule),
				typeof(IgbDropdownModule),
				typeof(IgbDropdownItemModule),
				typeof(IgbCardModule),
				typeof(IgbIconButtonModule));
			ctx.Services.AddScoped<IInventoryAppService>(sp => new MockInventoryAppService());
			var componentUnderTest = ctx.RenderComponent<Products>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
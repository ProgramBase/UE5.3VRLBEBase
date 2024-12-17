using Script.CoreUObject;
using Script.UnrealEd;
using Script.AlembicLibrary;
using Script.Library;

namespace Script.AlembicImporter
{
	[PathName("/Script/AlembicImporter.AlembicImportFactory")]
	public partial class UAlembicImportFactory : UFactory, IStaticClass
	{
		public UAbcImportSettings ImportSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ImportSettings, __ReturnBuffer);

					return *(UAbcImportSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ImportSettings, __InBuffer);
				}
			}
		}

		public bool bShowOption
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShowOption, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShowOption, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AlembicImporter.AlembicImportFactory");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ImportSettings = 0;

		private static uint __bShowOption = 0;
	}
}
using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DataDrivenConsoleVariableSettings")]
	public partial class UDataDrivenConsoleVariableSettings : UDeveloperSettings, IStaticClass
	{
		public TArray<FDataDrivenConsoleVariable> CVarsArray
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CVarsArray, __ReturnBuffer);

					return *(TArray<FDataDrivenConsoleVariable>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CVarsArray, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.DataDrivenConsoleVariableSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __CVarsArray = 0;
	}
}
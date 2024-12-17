using Script.CoreUObject;
using Script.Library;

namespace Script.NetCore
{
	[PathName("/Script/NetCore.EscalationManagerConfig")]
	public partial class UEscalationManagerConfig : UStatePerObjectConfig, IStaticClass
	{
		public TArray<FString> EscalationSeverity
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EscalationSeverity, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EscalationSeverity, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NetCore.EscalationManagerConfig");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __EscalationSeverity = 0;
	}
}
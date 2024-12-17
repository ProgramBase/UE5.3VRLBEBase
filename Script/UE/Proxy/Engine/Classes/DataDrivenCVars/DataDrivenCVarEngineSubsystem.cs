using Script.CoreUObject;
using Script.Engine.DataDrivenCVarEngineSubsystem;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DataDrivenCVarEngineSubsystem")]
	public partial class UDataDrivenCVarEngineSubsystem : UEngineSubsystem, IStaticClass
	{
		public FOnDataDrivenCVarChanged OnDataDrivenCVarDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnDataDrivenCVarDelegate, __ReturnBuffer);

					return *(FOnDataDrivenCVarChanged*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnDataDrivenCVarDelegate, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.DataDrivenCVarEngineSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __OnDataDrivenCVarDelegate = 0;
	}
}
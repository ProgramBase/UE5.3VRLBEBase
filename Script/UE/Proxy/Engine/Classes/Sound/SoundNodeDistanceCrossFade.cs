using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SoundNodeDistanceCrossFade")]
	public partial class USoundNodeDistanceCrossFade : USoundNode, IStaticClass
	{
		public TArray<FDistanceDatum> CrossFadeInput
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CrossFadeInput, __ReturnBuffer);

					return *(TArray<FDistanceDatum>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CrossFadeInput, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SoundNodeDistanceCrossFade");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __CrossFadeInput = 0;
	}
}
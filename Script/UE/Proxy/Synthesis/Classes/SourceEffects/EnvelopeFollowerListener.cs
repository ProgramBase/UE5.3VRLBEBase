using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.EnvelopeFollowerListener")]
	public partial class UEnvelopeFollowerListener : UActorComponent, IStaticClass
	{
		public FOnEnvelopeFollowerUpdate OnEnvelopeFollowerUpdate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnEnvelopeFollowerUpdate, __ReturnBuffer);

					return *(FOnEnvelopeFollowerUpdate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnEnvelopeFollowerUpdate, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Synthesis.EnvelopeFollowerListener");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __OnEnvelopeFollowerUpdate = 0;
	}
}
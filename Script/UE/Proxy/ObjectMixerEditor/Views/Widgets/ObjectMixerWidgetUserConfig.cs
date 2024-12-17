using Script.CoreUObject;
using Script.Library;

namespace Script.ObjectMixerEditor
{
	[PathName("/Script/ObjectMixerEditor.ObjectMixerWidgetUserConfig")]
	public partial class FObjectMixerWidgetUserConfig : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ObjectMixerEditor.ObjectMixerWidgetUserConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FObjectMixerWidgetUserConfig() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FObjectMixerWidgetUserConfig() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FObjectMixerWidgetUserConfig A, FObjectMixerWidgetUserConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FObjectMixerWidgetUserConfig A, FObjectMixerWidgetUserConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FObjectMixerWidgetUserConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSubclassOf<UObjectMixerObjectFilter> DefaultFilterClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DefaultFilterClass, __ReturnBuffer);

					return *(TSubclassOf<UObjectMixerObjectFilter>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DefaultFilterClass, __InBuffer);
				}
			}
		}

		private static uint __DefaultFilterClass = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
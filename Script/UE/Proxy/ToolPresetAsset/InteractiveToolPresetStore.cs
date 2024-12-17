using Script.CoreUObject;
using Script.Library;
using Script.SlateCore;

namespace Script.ToolPresetAsset
{
	[PathName("/Script/ToolPresetAsset.InteractiveToolPresetStore")]
	public partial class FInteractiveToolPresetStore : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ToolPresetAsset.InteractiveToolPresetStore");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FInteractiveToolPresetStore() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FInteractiveToolPresetStore() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FInteractiveToolPresetStore A, FInteractiveToolPresetStore B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FInteractiveToolPresetStore A, FInteractiveToolPresetStore B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FInteractiveToolPresetStore;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FInteractiveToolPresetDefinition> NamedPresets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NamedPresets, __ReturnBuffer);

					return *(TArray<FInteractiveToolPresetDefinition>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NamedPresets, __InBuffer);
				}
			}
		}

		public FText ToolLabel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ToolLabel, __ReturnBuffer);

					return *(FText*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ToolLabel, __InBuffer);
				}
			}
		}

		public FSlateBrush ToolIcon
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ToolIcon, __ReturnBuffer);

					return *(FSlateBrush*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ToolIcon, __InBuffer);
				}
			}
		}

		private static uint __NamedPresets = 0;

		private static uint __ToolLabel = 0;

		private static uint __ToolIcon = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
using Script.CoreUObject;
using Script.Library;

namespace Script.ToolPresetAsset
{
	[PathName("/Script/ToolPresetAsset.InteractiveToolPresetDefinition")]
	public partial class FInteractiveToolPresetDefinition : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ToolPresetAsset.InteractiveToolPresetDefinition");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FInteractiveToolPresetDefinition() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FInteractiveToolPresetDefinition() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FInteractiveToolPresetDefinition A, FInteractiveToolPresetDefinition B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FInteractiveToolPresetDefinition A, FInteractiveToolPresetDefinition B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FInteractiveToolPresetDefinition;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString StoredProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StoredProperties, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StoredProperties, __InBuffer);
				}
			}
		}

		public FString Label
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Label, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Label, __InBuffer);
				}
			}
		}

		public FString Tooltip
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Tooltip, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Tooltip, __InBuffer);
				}
			}
		}

		private static uint __StoredProperties = 0;

		private static uint __Label = 0;

		private static uint __Tooltip = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
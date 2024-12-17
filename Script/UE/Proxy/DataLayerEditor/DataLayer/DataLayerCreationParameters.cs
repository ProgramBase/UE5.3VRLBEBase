using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.DataLayerEditor
{
	[PathName("/Script/DataLayerEditor.DataLayerCreationParameters")]
	public partial class FDataLayerCreationParameters : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/DataLayerEditor.DataLayerCreationParameters");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDataLayerCreationParameters() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDataLayerCreationParameters() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDataLayerCreationParameters A, FDataLayerCreationParameters B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDataLayerCreationParameters A, FDataLayerCreationParameters B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDataLayerCreationParameters;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UDataLayerAsset DataLayerAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DataLayerAsset, __ReturnBuffer);

					return *(UDataLayerAsset*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DataLayerAsset, __InBuffer);
				}
			}
		}

		public AWorldDataLayers WorldDataLayers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WorldDataLayers, __ReturnBuffer);

					return *(AWorldDataLayers*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __WorldDataLayers, __InBuffer);
				}
			}
		}

		public bool bIsPrivate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsPrivate, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsPrivate, __InBuffer);
				}
			}
		}

		private static uint __DataLayerAsset = 0;

		private static uint __WorldDataLayers = 0;

		private static uint __bIsPrivate = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
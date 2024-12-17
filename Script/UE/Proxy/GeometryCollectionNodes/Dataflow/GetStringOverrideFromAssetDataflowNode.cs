using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.GetStringOverrideFromAssetDataflowNode")]
	public partial class FGetStringOverrideFromAssetDataflowNode : FDataflowOverrideNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.GetStringOverrideFromAssetDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGetStringOverrideFromAssetDataflowNode()
		{
		}

		public static bool operator ==(FGetStringOverrideFromAssetDataflowNode A, FGetStringOverrideFromAssetDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGetStringOverrideFromAssetDataflowNode A, FGetStringOverrideFromAssetDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGetStringOverrideFromAssetDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString String
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __String, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __String, __InBuffer);
				}
			}
		}

		public FString StringDefault
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StringDefault, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StringDefault, __InBuffer);
				}
			}
		}

		private static uint __String = 0;

		private static uint __StringDefault = 0;

	}
}
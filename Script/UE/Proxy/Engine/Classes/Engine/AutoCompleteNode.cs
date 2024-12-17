using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AutoCompleteNode")]
	public partial class FAutoCompleteNode : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AutoCompleteNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAutoCompleteNode() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAutoCompleteNode() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAutoCompleteNode A, FAutoCompleteNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAutoCompleteNode A, FAutoCompleteNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAutoCompleteNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int IndexChar
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __IndexChar, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __IndexChar, __InBuffer);
				}
			}
		}

		public TArray<int> AutoCompleteListIndices
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AutoCompleteListIndices, __ReturnBuffer);

					return *(TArray<int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AutoCompleteListIndices, __InBuffer);
				}
			}
		}

		private static uint __IndexChar = 0;

		private static uint __AutoCompleteListIndices = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
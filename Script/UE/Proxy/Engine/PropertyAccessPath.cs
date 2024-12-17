using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PropertyAccessPath")]
	public partial class FPropertyAccessPath : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.PropertyAccessPath");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPropertyAccessPath() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPropertyAccessPath() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPropertyAccessPath A, FPropertyAccessPath B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPropertyAccessPath A, FPropertyAccessPath B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPropertyAccessPath;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int PathSegmentStartIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PathSegmentStartIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PathSegmentStartIndex, __InBuffer);
				}
			}
		}

		public int PathSegmentCount
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PathSegmentCount, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PathSegmentCount, __InBuffer);
				}
			}
		}

		private static uint __PathSegmentStartIndex = 0;

		private static uint __PathSegmentCount = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
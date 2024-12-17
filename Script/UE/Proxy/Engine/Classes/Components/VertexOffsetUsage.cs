using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.VertexOffsetUsage")]
	public partial class FVertexOffsetUsage : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.VertexOffsetUsage");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FVertexOffsetUsage() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FVertexOffsetUsage() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FVertexOffsetUsage A, FVertexOffsetUsage B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FVertexOffsetUsage A, FVertexOffsetUsage B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FVertexOffsetUsage;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int Usage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Usage, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Usage, __InBuffer);
				}
			}
		}

		private static uint __Usage = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
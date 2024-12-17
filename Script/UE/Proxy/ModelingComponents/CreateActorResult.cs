using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.CreateActorResult")]
	public partial class FCreateActorResult : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ModelingComponents.CreateActorResult");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCreateActorResult() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCreateActorResult() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCreateActorResult A, FCreateActorResult B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCreateActorResult A, FCreateActorResult B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCreateActorResult;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ECreateModelingObjectResult ResultCode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ResultCode, __ReturnBuffer);

					return *(ECreateModelingObjectResult*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ResultCode, __InBuffer);
				}
			}
		}

		public AActor NewActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NewActor, __ReturnBuffer);

					return *(AActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NewActor, __InBuffer);
				}
			}
		}

		private static uint __ResultCode = 0;

		private static uint __NewActor = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
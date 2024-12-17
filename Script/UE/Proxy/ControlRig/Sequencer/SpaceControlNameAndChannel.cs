using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.SpaceControlNameAndChannel")]
	public partial class FSpaceControlNameAndChannel : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.SpaceControlNameAndChannel");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSpaceControlNameAndChannel() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSpaceControlNameAndChannel() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSpaceControlNameAndChannel A, FSpaceControlNameAndChannel B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSpaceControlNameAndChannel A, FSpaceControlNameAndChannel B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSpaceControlNameAndChannel;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName ControlName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ControlName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ControlName, __InBuffer);
				}
			}
		}

		public FMovieSceneControlRigSpaceChannel SpaceCurve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SpaceCurve, __ReturnBuffer);

					return *(FMovieSceneControlRigSpaceChannel*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SpaceCurve, __InBuffer);
				}
			}
		}

		private static uint __ControlName = 0;

		private static uint __SpaceCurve = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
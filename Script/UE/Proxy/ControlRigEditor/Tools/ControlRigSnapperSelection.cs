using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.ControlRigEditor
{
	[PathName("/Script/ControlRigEditor.ControlRigSnapperSelection")]
	public partial class FControlRigSnapperSelection : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRigEditor.ControlRigSnapperSelection");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FControlRigSnapperSelection() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FControlRigSnapperSelection() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FControlRigSnapperSelection A, FControlRigSnapperSelection B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FControlRigSnapperSelection A, FControlRigSnapperSelection B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FControlRigSnapperSelection;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FActorForWorldTransforms> Actors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Actors, __ReturnBuffer);

					return *(TArray<FActorForWorldTransforms>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Actors, __InBuffer);
				}
			}
		}

		public TArray<FControlRigForWorldTransforms> ControlRigs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ControlRigs, __ReturnBuffer);

					return *(TArray<FControlRigForWorldTransforms>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ControlRigs, __InBuffer);
				}
			}
		}

		private static uint __Actors = 0;

		private static uint __ControlRigs = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
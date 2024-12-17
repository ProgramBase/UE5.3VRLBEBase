using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.BehaviorInfo")]
	public partial class FBehaviorInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/InteractiveToolsFramework.BehaviorInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBehaviorInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBehaviorInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBehaviorInfo A, FBehaviorInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBehaviorInfo A, FBehaviorInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBehaviorInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UInputBehavior Behavior
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Behavior, __ReturnBuffer);

					return *(UInputBehavior*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Behavior, __InBuffer);
				}
			}
		}

		private static uint __Behavior = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
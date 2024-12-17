using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.BehaviorTreeTemplateInfo")]
	public partial class FBehaviorTreeTemplateInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AIModule.BehaviorTreeTemplateInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBehaviorTreeTemplateInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBehaviorTreeTemplateInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBehaviorTreeTemplateInfo A, FBehaviorTreeTemplateInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBehaviorTreeTemplateInfo A, FBehaviorTreeTemplateInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBehaviorTreeTemplateInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UBehaviorTree Asset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Asset, __ReturnBuffer);

					return *(UBehaviorTree*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Asset, __InBuffer);
				}
			}
		}

		public UBTCompositeNode Template
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Template, __ReturnBuffer);

					return *(UBTCompositeNode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Template, __InBuffer);
				}
			}
		}

		private static uint __Asset = 0;

		private static uint __Template = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
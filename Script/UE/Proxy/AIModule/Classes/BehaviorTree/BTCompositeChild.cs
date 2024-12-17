using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.BTCompositeChild")]
	public partial class FBTCompositeChild : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AIModule.BTCompositeChild");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBTCompositeChild() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBTCompositeChild() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBTCompositeChild A, FBTCompositeChild B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBTCompositeChild A, FBTCompositeChild B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBTCompositeChild;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UBTCompositeNode ChildComposite
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ChildComposite, __ReturnBuffer);

					return *(UBTCompositeNode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ChildComposite, __InBuffer);
				}
			}
		}

		public UBTTaskNode ChildTask
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ChildTask, __ReturnBuffer);

					return *(UBTTaskNode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ChildTask, __InBuffer);
				}
			}
		}

		public TArray<UBTDecorator> Decorators
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Decorators, __ReturnBuffer);

					return *(TArray<UBTDecorator>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Decorators, __InBuffer);
				}
			}
		}

		public TArray<FBTDecoratorLogic> DecoratorOps
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DecoratorOps, __ReturnBuffer);

					return *(TArray<FBTDecoratorLogic>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DecoratorOps, __InBuffer);
				}
			}
		}

		private static uint __ChildComposite = 0;

		private static uint __ChildTask = 0;

		private static uint __Decorators = 0;

		private static uint __DecoratorOps = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
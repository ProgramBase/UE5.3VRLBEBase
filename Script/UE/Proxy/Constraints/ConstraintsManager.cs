using Script.CoreUObject;
using Script.Constraints.ConstraintsManager;
using Script.Library;

namespace Script.Constraints
{
	[PathName("/Script/Constraints.ConstraintsManager")]
	public partial class UConstraintsManager : UObject, IStaticClass
	{
		public FOnConstraintAdded OnConstraintAdded_BP
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnConstraintAdded_BP, __ReturnBuffer);

					return *(FOnConstraintAdded*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnConstraintAdded_BP, __InBuffer);
				}
			}
		}

		public FOnConstraintRemoved OnConstraintRemoved_BP
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnConstraintRemoved_BP, __ReturnBuffer);

					return *(FOnConstraintRemoved*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnConstraintRemoved_BP, __InBuffer);
				}
			}
		}

		public TArray<UTickableConstraint> Constraints
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Constraints, __ReturnBuffer);

					return *(TArray<UTickableConstraint>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Constraints, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Constraints.ConstraintsManager");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __OnConstraintAdded_BP = 0;

		private static uint __OnConstraintRemoved_BP = 0;

		private static uint __Constraints = 0;
	}
}
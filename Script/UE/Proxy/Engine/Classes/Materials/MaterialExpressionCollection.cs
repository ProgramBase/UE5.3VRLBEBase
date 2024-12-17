using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialExpressionCollection")]
	public partial class FMaterialExpressionCollection : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.MaterialExpressionCollection");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMaterialExpressionCollection() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMaterialExpressionCollection() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMaterialExpressionCollection A, FMaterialExpressionCollection B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMaterialExpressionCollection A, FMaterialExpressionCollection B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMaterialExpressionCollection;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<UMaterialExpression> Expressions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Expressions, __ReturnBuffer);

					return *(TArray<UMaterialExpression>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Expressions, __InBuffer);
				}
			}
		}

		public TArray<UMaterialExpressionComment> EditorComments
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EditorComments, __ReturnBuffer);

					return *(TArray<UMaterialExpressionComment>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EditorComments, __InBuffer);
				}
			}
		}

		public UMaterialExpressionExecBegin ExpressionExecBegin
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExpressionExecBegin, __ReturnBuffer);

					return *(UMaterialExpressionExecBegin*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExpressionExecBegin, __InBuffer);
				}
			}
		}

		public UMaterialExpressionExecEnd ExpressionExecEnd
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExpressionExecEnd, __ReturnBuffer);

					return *(UMaterialExpressionExecEnd*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExpressionExecEnd, __InBuffer);
				}
			}
		}

		private static uint __Expressions = 0;

		private static uint __EditorComments = 0;

		private static uint __ExpressionExecBegin = 0;

		private static uint __ExpressionExecEnd = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
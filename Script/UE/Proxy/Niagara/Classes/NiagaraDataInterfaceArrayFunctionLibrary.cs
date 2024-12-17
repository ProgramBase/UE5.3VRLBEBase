using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary")]
	public partial class UNiagaraDataInterfaceArrayFunctionLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraDataInterfaceArrayFunctionLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void SetNiagaraArrayVectorValue(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index, FVector Value, bool bSizeToFit)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[29];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = Index;

				*(nint*)(__InBuffer + 20) = Value?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 28) = bSizeToFit;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetNiagaraArrayVectorValue, __InBuffer);
			}
		}

		public static void SetNiagaraArrayVector4Value(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index, FVector4 Value, bool bSizeToFit)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[29];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = Index;

				*(nint*)(__InBuffer + 20) = Value?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 28) = bSizeToFit;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetNiagaraArrayVector4Value, __InBuffer);
			}
		}

		public static void SetNiagaraArrayVector4(UNiagaraComponent NiagaraSystem, FName OverrideName, TArray<FVector4> ArrayData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ArrayData?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetNiagaraArrayVector4, __InBuffer);
			}
		}

		public static void SetNiagaraArrayVector2DValue(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index, FVector2D Value, bool bSizeToFit)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[29];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = Index;

				*(nint*)(__InBuffer + 20) = Value?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 28) = bSizeToFit;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetNiagaraArrayVector2DValue, __InBuffer);
			}
		}

		public static void SetNiagaraArrayVector2D(UNiagaraComponent NiagaraSystem, FName OverrideName, TArray<FVector2D> ArrayData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ArrayData?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetNiagaraArrayVector2D, __InBuffer);
			}
		}

		public static void SetNiagaraArrayVector(UNiagaraComponent NiagaraSystem, FName OverrideName, TArray<FVector> ArrayData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ArrayData?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetNiagaraArrayVector, __InBuffer);
			}
		}

		public static void SetNiagaraArrayUInt8Value(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index, int Value, bool bSizeToFit)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = Index;

				*(int*)(__InBuffer + 20) = Value;

				*(bool*)(__InBuffer + 24) = bSizeToFit;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetNiagaraArrayUInt8Value, __InBuffer);
			}
		}

		public static void SetNiagaraArrayUInt8(UNiagaraComponent NiagaraSystem, FName OverrideName, TArray<int> ArrayData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ArrayData?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetNiagaraArrayUInt8, __InBuffer);
			}
		}

		public static void SetNiagaraArrayQuatValue(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index, FQuat Value, bool bSizeToFit)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[29];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = Index;

				*(nint*)(__InBuffer + 20) = Value?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 28) = bSizeToFit;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetNiagaraArrayQuatValue, __InBuffer);
			}
		}

		public static void SetNiagaraArrayQuat(UNiagaraComponent NiagaraSystem, FName OverrideName, TArray<FQuat> ArrayData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ArrayData?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetNiagaraArrayQuat, __InBuffer);
			}
		}

		public static void SetNiagaraArrayPositionValue(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index, FVector Value, bool bSizeToFit)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[29];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = Index;

				*(nint*)(__InBuffer + 20) = Value?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 28) = bSizeToFit;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetNiagaraArrayPositionValue, __InBuffer);
			}
		}

		public static void SetNiagaraArrayPosition(UNiagaraComponent NiagaraSystem, FName OverrideName, TArray<FVector> ArrayData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ArrayData?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetNiagaraArrayPosition, __InBuffer);
			}
		}

		/// <param name="bApplyLWCRebase">
		/// When enabled the matrix translation will have the simulation tile offset subtracted from it
		/// </param>
		public static void SetNiagaraArrayMatrixValue(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index, FMatrix Value, bool bSizeToFit, bool bApplyLWCRebase = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[30];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = Index;

				*(nint*)(__InBuffer + 20) = Value?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 28) = bSizeToFit;

				*(bool*)(__InBuffer + 29) = bApplyLWCRebase;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetNiagaraArrayMatrixValue, __InBuffer);
			}
		}

		/// <param name="bApplyLWCRebase">
		/// When enabled the matrix translation will have the simulation tile offset subtracted from it
		/// </param>
		public static void SetNiagaraArrayMatrix(UNiagaraComponent NiagaraSystem, FName OverrideName, TArray<FMatrix> ArrayData, bool bApplyLWCRebase = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ArrayData?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bApplyLWCRebase;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetNiagaraArrayMatrix, __InBuffer);
			}
		}

		public static void SetNiagaraArrayInt32Value(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index, int Value, bool bSizeToFit)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = Index;

				*(int*)(__InBuffer + 20) = Value;

				*(bool*)(__InBuffer + 24) = bSizeToFit;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetNiagaraArrayInt32Value, __InBuffer);
			}
		}

		public static void SetNiagaraArrayInt32(UNiagaraComponent NiagaraSystem, FName OverrideName, TArray<int> ArrayData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ArrayData?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetNiagaraArrayInt32, __InBuffer);
			}
		}

		public static void SetNiagaraArrayFloatValue(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index, float Value, bool bSizeToFit)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = Index;

				*(float*)(__InBuffer + 20) = Value;

				*(bool*)(__InBuffer + 24) = bSizeToFit;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetNiagaraArrayFloatValue, __InBuffer);
			}
		}

		public static void SetNiagaraArrayFloat(UNiagaraComponent NiagaraSystem, FName OverrideName, TArray<float> ArrayData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ArrayData?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetNiagaraArrayFloat, __InBuffer);
			}
		}

		public static void SetNiagaraArrayColorValue(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index, FLinearColor Value, bool bSizeToFit)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[29];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = Index;

				*(nint*)(__InBuffer + 20) = Value?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 28) = bSizeToFit;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetNiagaraArrayColorValue, __InBuffer);
			}
		}

		public static void SetNiagaraArrayColor(UNiagaraComponent NiagaraSystem, FName OverrideName, TArray<FLinearColor> ArrayData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ArrayData?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetNiagaraArrayColor, __InBuffer);
			}
		}

		public static void SetNiagaraArrayBoolValue(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index, bool Value, bool bSizeToFit)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[22];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = Index;

				*(bool*)(__InBuffer + 20) = Value;

				*(bool*)(__InBuffer + 21) = bSizeToFit;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetNiagaraArrayBoolValue, __InBuffer);
			}
		}

		public static void SetNiagaraArrayBool(UNiagaraComponent NiagaraSystem, FName OverrideName, TArray<bool> ArrayData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ArrayData?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetNiagaraArrayBool, __InBuffer);
			}
		}

		public static FVector GetNiagaraArrayVectorValue(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = Index;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNiagaraArrayVectorValue, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FVector4 GetNiagaraArrayVector4Value(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = Index;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNiagaraArrayVector4Value, __InBuffer, __ReturnBuffer);

				return *(FVector4*)__ReturnBuffer;
			}
		}

		public static TArray<FVector4> GetNiagaraArrayVector4(UNiagaraComponent NiagaraSystem, FName OverrideName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNiagaraArrayVector4, __InBuffer, __ReturnBuffer);

				return *(TArray<FVector4>*)__ReturnBuffer;
			}
		}

		public static FVector2D GetNiagaraArrayVector2DValue(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = Index;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNiagaraArrayVector2DValue, __InBuffer, __ReturnBuffer);

				return *(FVector2D*)__ReturnBuffer;
			}
		}

		public static TArray<FVector2D> GetNiagaraArrayVector2D(UNiagaraComponent NiagaraSystem, FName OverrideName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNiagaraArrayVector2D, __InBuffer, __ReturnBuffer);

				return *(TArray<FVector2D>*)__ReturnBuffer;
			}
		}

		public static TArray<FVector> GetNiagaraArrayVector(UNiagaraComponent NiagaraSystem, FName OverrideName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNiagaraArrayVector, __InBuffer, __ReturnBuffer);

				return *(TArray<FVector>*)__ReturnBuffer;
			}
		}

		public static int GetNiagaraArrayUInt8Value(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = Index;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNiagaraArrayUInt8Value, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static TArray<int> GetNiagaraArrayUInt8(UNiagaraComponent NiagaraSystem, FName OverrideName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNiagaraArrayUInt8, __InBuffer, __ReturnBuffer);

				return *(TArray<int>*)__ReturnBuffer;
			}
		}

		public static FQuat GetNiagaraArrayQuatValue(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = Index;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNiagaraArrayQuatValue, __InBuffer, __ReturnBuffer);

				return *(FQuat*)__ReturnBuffer;
			}
		}

		public static TArray<FQuat> GetNiagaraArrayQuat(UNiagaraComponent NiagaraSystem, FName OverrideName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNiagaraArrayQuat, __InBuffer, __ReturnBuffer);

				return *(TArray<FQuat>*)__ReturnBuffer;
			}
		}

		public static FVector GetNiagaraArrayPositionValue(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = Index;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNiagaraArrayPositionValue, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static TArray<FVector> GetNiagaraArrayPosition(UNiagaraComponent NiagaraSystem, FName OverrideName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNiagaraArrayPosition, __InBuffer, __ReturnBuffer);

				return *(TArray<FVector>*)__ReturnBuffer;
			}
		}

		/// <param name="bApplyLWCRebase">
		/// When enabled the matrix translation will have the simulation tile offset added to it
		/// </param>
		public static FMatrix GetNiagaraArrayMatrixValue(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index, bool bApplyLWCRebase = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[21];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = Index;

				*(bool*)(__InBuffer + 20) = bApplyLWCRebase;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNiagaraArrayMatrixValue, __InBuffer, __ReturnBuffer);

				return *(FMatrix*)__ReturnBuffer;
			}
		}

		/// <param name="bApplyLWCRebase">
		/// When enabled the matrix translation will have the simulation tile offset added to it
		/// </param>
		public static TArray<FMatrix> GetNiagaraArrayMatrix(UNiagaraComponent NiagaraSystem, FName OverrideName, bool bApplyLWCRebase = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bApplyLWCRebase;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNiagaraArrayMatrix, __InBuffer, __ReturnBuffer);

				return *(TArray<FMatrix>*)__ReturnBuffer;
			}
		}

		public static int GetNiagaraArrayInt32Value(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = Index;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNiagaraArrayInt32Value, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static TArray<int> GetNiagaraArrayInt32(UNiagaraComponent NiagaraSystem, FName OverrideName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNiagaraArrayInt32, __InBuffer, __ReturnBuffer);

				return *(TArray<int>*)__ReturnBuffer;
			}
		}

		public static float GetNiagaraArrayFloatValue(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = Index;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNiagaraArrayFloatValue, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static TArray<float> GetNiagaraArrayFloat(UNiagaraComponent NiagaraSystem, FName OverrideName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNiagaraArrayFloat, __InBuffer, __ReturnBuffer);

				return *(TArray<float>*)__ReturnBuffer;
			}
		}

		public static FLinearColor GetNiagaraArrayColorValue(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = Index;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNiagaraArrayColorValue, __InBuffer, __ReturnBuffer);

				return *(FLinearColor*)__ReturnBuffer;
			}
		}

		public static TArray<FLinearColor> GetNiagaraArrayColor(UNiagaraComponent NiagaraSystem, FName OverrideName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNiagaraArrayColor, __InBuffer, __ReturnBuffer);

				return *(TArray<FLinearColor>*)__ReturnBuffer;
			}
		}

		public static bool GetNiagaraArrayBoolValue(UNiagaraComponent NiagaraSystem, FName OverrideName, int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = Index;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNiagaraArrayBoolValue, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static TArray<bool> GetNiagaraArrayBool(UNiagaraComponent NiagaraSystem, FName OverrideName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NiagaraSystem?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OverrideName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNiagaraArrayBool, __InBuffer, __ReturnBuffer);

				return *(TArray<bool>*)__ReturnBuffer;
			}
		}

		private static uint __SetNiagaraArrayVectorValue = 0;

		private static uint __SetNiagaraArrayVector4Value = 0;

		private static uint __SetNiagaraArrayVector4 = 0;

		private static uint __SetNiagaraArrayVector2DValue = 0;

		private static uint __SetNiagaraArrayVector2D = 0;

		private static uint __SetNiagaraArrayVector = 0;

		private static uint __SetNiagaraArrayUInt8Value = 0;

		private static uint __SetNiagaraArrayUInt8 = 0;

		private static uint __SetNiagaraArrayQuatValue = 0;

		private static uint __SetNiagaraArrayQuat = 0;

		private static uint __SetNiagaraArrayPositionValue = 0;

		private static uint __SetNiagaraArrayPosition = 0;

		private static uint __SetNiagaraArrayMatrixValue = 0;

		private static uint __SetNiagaraArrayMatrix = 0;

		private static uint __SetNiagaraArrayInt32Value = 0;

		private static uint __SetNiagaraArrayInt32 = 0;

		private static uint __SetNiagaraArrayFloatValue = 0;

		private static uint __SetNiagaraArrayFloat = 0;

		private static uint __SetNiagaraArrayColorValue = 0;

		private static uint __SetNiagaraArrayColor = 0;

		private static uint __SetNiagaraArrayBoolValue = 0;

		private static uint __SetNiagaraArrayBool = 0;

		private static uint __GetNiagaraArrayVectorValue = 0;

		private static uint __GetNiagaraArrayVector4Value = 0;

		private static uint __GetNiagaraArrayVector4 = 0;

		private static uint __GetNiagaraArrayVector2DValue = 0;

		private static uint __GetNiagaraArrayVector2D = 0;

		private static uint __GetNiagaraArrayVector = 0;

		private static uint __GetNiagaraArrayUInt8Value = 0;

		private static uint __GetNiagaraArrayUInt8 = 0;

		private static uint __GetNiagaraArrayQuatValue = 0;

		private static uint __GetNiagaraArrayQuat = 0;

		private static uint __GetNiagaraArrayPositionValue = 0;

		private static uint __GetNiagaraArrayPosition = 0;

		private static uint __GetNiagaraArrayMatrixValue = 0;

		private static uint __GetNiagaraArrayMatrix = 0;

		private static uint __GetNiagaraArrayInt32Value = 0;

		private static uint __GetNiagaraArrayInt32 = 0;

		private static uint __GetNiagaraArrayFloatValue = 0;

		private static uint __GetNiagaraArrayFloat = 0;

		private static uint __GetNiagaraArrayColorValue = 0;

		private static uint __GetNiagaraArrayColor = 0;

		private static uint __GetNiagaraArrayBoolValue = 0;

		private static uint __GetNiagaraArrayBool = 0;
	}
}
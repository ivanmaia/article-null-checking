using BenchmarkDotNet.Attributes;

namespace NullChecking;

public class DemoNullChecking
{
    private object objeto = null;
    const int OPERATIONSPERINVOKE = 1000;
    const int LOOPCOUNT = 1000;

    [Benchmark(Baseline=true, OperationsPerInvoke = OPERATIONSPERINVOKE)]
    public void IsNullUsingEqualityOperator()
    {
        for (int i = 0; i < LOOPCOUNT; i++)
        {
            _ = objeto == null;    
        }
    }

    [Benchmark(OperationsPerInvoke = OPERATIONSPERINVOKE)]
    public void IsNullUsingPatternMatching()
    {
        for (int i = 0; i < LOOPCOUNT; i++)
        {
            _ = objeto is null;
        }
    }

    [Benchmark(OperationsPerInvoke = OPERATIONSPERINVOKE)]
    public void IsNullUsingReferenceEquals()
    {
        for (int i = 0; i < LOOPCOUNT; i++)
        {
            _ = ReferenceEquals(objeto, null);
        }
    }

    [Benchmark(OperationsPerInvoke = OPERATIONSPERINVOKE)]
    public void IsNullUsingEquals()
    {
        for (int i = 0; i < LOOPCOUNT; i++)
        {
            _ = Equals(objeto, null);
        }
    }

    [Benchmark(OperationsPerInvoke = OPERATIONSPERINVOKE)]
    public void IsNullUsingExtensionMethod()
    {
        for (int i = 0; i < LOOPCOUNT; i++)
        {
            _ = objeto.IsNull();
        }
    }

    [Benchmark(OperationsPerInvoke = OPERATIONSPERINVOKE)]
    public void IsNullUsingStaticMethod()
    {
        for (int i = 0; i < LOOPCOUNT; i++)
        {
            _ = NullCheck.IsNull(objeto);
        }
    }
}
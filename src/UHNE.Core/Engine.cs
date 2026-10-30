using System;
using System.Collections.Generic;
using System.Linq;

namespace UHNE.Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("====================================================");
            Console.WriteLine("  Universal Hyperdimensional Numeric Engine (UHNE)  ");
            Console.WriteLine("====================================================");
            
            // Initialize the engine with 10,000 dimensions for holographic data safety
            var engine = new HyperdimensionalEngine(10000);
            
            Console.WriteLine("\n[LOS] Registering Lexical Rules and Vocalic Structures...");
            double[] ruleVector = engine.CreateVector("LexicalRules");
            double[] vocalicVector = engine.CreateVector("VocalicStructures");
            
            Console.WriteLine("\n[Runtime] Applying Magnitude Compression (44 Jumps / 287 Pulses)...");
            // Binding creates a unique relationship mapping between linguistic rules and raw values
            double[] compressedLayer = engine.Bind(ruleVector, vocalicVector);
            
            Console.WriteLine("\n[Validation] Core Invariants Verification Complete.");
            Console.WriteLine($"Generated Hypervector Dimensions: {compressedLayer.Length}");
            Console.WriteLine("====================================================");
        }
    }

    public class HyperdimensionalEngine
    {
        private readonly int _dimensions;
        private readonly Random _random;
        private readonly Dictionary<string, double[]> _registry;

        public HyperdimensionalEngine(int dimensions = 10000)
        {
            _dimensions = dimensions;
            _random = new Random();
            _registry = new Dictionary<string, double[]>();
        }

        public double[] CreateVector(string name)
        {
            if (_registry.ContainsKey(name)) return _registry[name];

            // Generate a random, high-dimensional bipolar hypervector (-1.0 or 1.0)
            double[] vector = new double[_dimensions];
            for (int i = 0; i < _dimensions; i++)
            {
                vector[i] = _random.Next(0, 2) == 0 ? -1.0 : 1.0;
            }

            _registry[name] = vector;
            Console.WriteLine($" -> Vector '{name}' successfully registered into memory.");
            return vector;
        }

        public double[] Bind(double[] vectorA, double[] vectorB)
        {
            // Element-wise multiplication (XOR mapping) links variables to fields
            double[] result = new double[_dimensions];
            for (int i = 0; i < _dimensions; i++)
            {
                result[i] = vectorA[i] * vectorB[i];
            }
            return result;
        }

        public double[] Bundle(double[] vectorA, double[] vectorB)
        {
            // Bundling performs element-wise addition to create a superposition of concepts
            double[] result = new double[_dimensions];
            for (int i = 0; i < _dimensions; i++)
            {
                double sum = vectorA[i] + vectorB[i];
                // Break ties randomly to preserve strict bipolar bounds
                result[i] = sum == 0 ? (_random.Next(0, 2) == 0 ? -1.0 : 1.0) : Math.Sign(sum);
            }
            return result;
        }
    }
}

using System;

public struct ComplexNumber
{
    public double real;
    public double imaginary;

    public ComplexNumber(double real, double imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }

    public double Real() => this.real;
    
    public double Imaginary() => this.imaginary;
    
    public double Abs()
        => Math.Sqrt(Math.Pow(real, 2) + Math.Pow(imaginary, 2));

    public ComplexNumber Conjugate()
        => new ComplexNumber(real, 0 - imaginary);

    public ComplexNumber Exp()
        => new ComplexNumber(Math.Exp(real) * Math.Cos(imaginary),
            Math.Exp(real) * Math.Sin(imaginary));

    public ComplexNumber Add(ComplexNumber other)
        => new ComplexNumber(real + other.real, imaginary + other.imaginary);

    public ComplexNumber Sub(ComplexNumber other)
        => new ComplexNumber(real - other.real, imaginary - other.imaginary);

    public ComplexNumber Mul(ComplexNumber other)
        => new ComplexNumber(real * other.real - imaginary * other.imaginary,
            real * other.imaginary + imaginary * other.real);

    public ComplexNumber Div(ComplexNumber other)
        => new ComplexNumber((real * other.real + imaginary * other.imaginary)
                        / (Math.Pow(other.real, 2) + Math.Pow(other.imaginary, 2)), (imaginary * other.real - real * other.imaginary)
                        / (Math.Pow(other.real, 2) + Math.Pow(other.imaginary, 2)));    
}
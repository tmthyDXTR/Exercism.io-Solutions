// This file was auto-generated based on version 1.3.0 of the canonical data.

using Xunit;

public class RnaTranscriptionTest
{
    [Fact]
    public void Empty_rna_sequence()
    {
        Assert.Equal("", RnaTranscription.ToRna(""));
    }

    [Fact]
    public void Rna_complement_of_cytosine_is_guanine()
    {
        Assert.Equal("G", RnaTranscription.ToRna("C"));
    }

    [Fact]
    public void Rna_complement_of_guanine_is_cytosine()
    {
        Assert.Equal("C", RnaTranscription.ToRna("G"));
    }

    [Fact]
    public void Rna_complement_of_thymine_is_adenine()
    {
        Assert.Equal("A", RnaTranscription.ToRna("T"));
    }

    [Fact]
    public void Rna_complement_of_adenine_is_uracil()
    {
        Assert.Equal("U", RnaTranscription.ToRna("A"));
    }

    [Fact]
    public void Rna_complement()
    {
        Assert.Equal("UGCACCAGAAUU", RnaTranscription.ToRna("ACGTGGTCTTAA"));
    }
    [Fact]
    public void Dna_Test()
    {
        Assert.Equal("GCTAAG", RnaTranscription.ToDna("CGAUUC"));
    }
}
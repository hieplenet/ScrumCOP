package main

import (
  "testing"
  "github.com/stretchr/testify/assert"
)

func TestBatman(t *testing.T) {
  assert := assert.New(t)
  assert.Equal("iambatman", IAMBATMAN("a"))
}


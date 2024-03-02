# Maintainer: TheBunnyMan123 <bunny@thekillerbunny.com>
pkgname='math'
pkgver=v1.1.0
pkgrel=2
pkgdesc="A program that takes in an expression and applies an operation to it"
arch=('x86_64')
url="https://github.com/TheBunnyMan123/math"
license=('MIT')
depends=('git')
makedepends=('dotnet-sdk-8.0')
provides=('math')
source=("$pkgname::https://github.com/TheBunnyMan123/math/archive/refs/tags/$pkgver.tar.gz")
sha256sums=('SKIP')

build() {
	cd "$srcdir/$pkgname"
  dotnet publish -c Release -o release
}

package() {
	cd "$srcdir/$pkgname"
  install -Dm755 ./release/math "$pkgdir/usr/bin/math"
}

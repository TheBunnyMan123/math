# Maintainer: TheBunnyMan123 <bunny@thekillerbunny.com>
pkgname='math'
pkgver=1.1.0
pkgrel=2
pkgdesc="A program that takes in an expression and applies an operation to it"
arch=('x86_64')
url="https://github.com/TheBunnyMan123/math"
license=('MIT')
depends=('git')
makedepends=('dotnet-sdk-8.0')
provides=('math')
source=("$pkgname-$pkgver.tar.gz::https://github.com/TheBunnyMan123/math/archive/refs/tags/v$pkgver.tar.gz")
sha256sums=('SKIP')

build() {
  ls $srcdir
	cd "$srcdir/$pkgname-$pkgver"
  dotnet publish -c Release -o release
}

package() {
	cd "$srcdir/$pkgname-$pkgver"
  install -Dm755 ./release/math "$pkgdir/usr/bin/math"
}

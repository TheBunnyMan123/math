# Maintainer: TheBunnyMan123 <bunny@thekillerbunny.com>
pkgname='math'
pkgver=v1.0.0.r0.g300adda
pkgrel=1
pkgdesc="A program that takes in an expression and applies an operation to it"
arch=('x86_64' 'aarch64')
url="https://github.com/TheBunnyMan123/math"
license=('MIT')
depends=('git')
makedepends=('dotnet-sdk-8.0')
provides=('math')
source=("$pkgname::git+https://github.com/TheBunnyMan123/math.git")
sha256sums=('SKIP')

pkgver() {
  cd "$pkgname"
  git describe --long --tags --abbrev=7 | sed 's/\([^-]*-g\)/r\1/;s/-/./g'
}

build() {
	cd "$srcdir/$pkgname"
  dotnet publish -c Release -o release
}

package() {
	cd "$srcdir/$pkgname"
  install -Dm755 ./release/math "$pkgdir/usr/bin/math"
}
